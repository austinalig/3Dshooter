using UnityEngine;
using System.Collections;

public class enemyshoot : MonoBehaviour {
	public Rigidbody projectile;
	public int speed = 1000000;
	public float fireRate = 0.8F;
	private float nextFire = 0.0F;
	SampleAgentScript script;
	GameObject gob;
	bool change;
	
	void Start () {
			GameObject[] gos;
			gos = GameObject.FindGameObjectsWithTag("Enemy");
			GameObject closest = null;
			float distance = Mathf.Infinity;
			Vector3 position = transform.position;
			foreach (GameObject go in gos) {
				Vector3 diff = go.transform.position - position;
				float curDistance = diff.sqrMagnitude;
				if (curDistance < distance) {
					closest = go;
					distance = curDistance;
				}
			}
			gob = closest;
		}

	
	void Update(){

		SampleAgentScript script = gob.GetComponent<SampleAgentScript> ();
		if ((script.fire == true) && (Time.time > nextFire)) {
			nextFire = Time.time + fireRate;
			Rigidbody clone = Instantiate(projectile, transform.position, transform.rotation)as Rigidbody;
			if(clone != null){
				clone.velocity = transform.TransformDirection(Vector3.forward * speed);}
		}
	}
}