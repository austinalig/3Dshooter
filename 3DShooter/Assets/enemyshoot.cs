using UnityEngine;
using System.Collections;

public class enemyshoot : MonoBehaviour {
	public Rigidbody projectile;
	public int speed = 10;
	public float fireRate = 0.5F;
	private float nextFire = 0.0F;
	void onTriggerEnter(Collider other){
		if ((other.name != "Bob") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Rigidbody clone = Instantiate(projectile, transform.position, transform.rotation)as Rigidbody;
			if(clone != null){
				clone.velocity = transform.TransformDirection(Vector3.forward * speed);}
		}
	}
}