using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public Rigidbody projectile;
	public int speed = 10;
	public float fireRate = 0.5F;
	private float nextFire = 0.0F;
	void Update() {
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Rigidbody clone = Instantiate(projectile, transform.position, transform.rotation)as Rigidbody;
			if(clone != null){
			clone.velocity = transform.TransformDirection(Vector3.forward * speed);}
		}
	}
}