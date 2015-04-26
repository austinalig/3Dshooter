using UnityEngine;
using System.Collections;

public class enemyshoot : MonoBehaviour {
	public Rigidbody projectile;
	public int speed = 1000000;
	public float fireRate = 0.8F;
	private float nextFire = 0.0F;
	SampleAgentScript script;
	GameObject go;
	
	void Start () {
	}
	
	void Update(){
		GameObject go = GameObject.Find ("Enemy(Clone)");
		SampleAgentScript script = go.GetComponent<SampleAgentScript> ();
		if ((script.fire == true) && (Time.time > nextFire)) {
			nextFire = Time.time + fireRate;
			Rigidbody clone = Instantiate(projectile, transform.position, transform.rotation)as Rigidbody;
			if(clone != null){
				clone.velocity = transform.TransformDirection(Vector3.forward * speed);}
		}
	}
}