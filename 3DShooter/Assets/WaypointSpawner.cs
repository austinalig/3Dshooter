using UnityEngine;
using System.Collections;

public class WaypointSpawner : MonoBehaviour {
		public Rigidbody projectile;
		public int speed = 0;
		public float fireRate = 0.5F;
		private float nextFire = 0.0F;
		public GameObject[] gos;
		public int i = 0;
	 	public int maxenemies = 15;
	   public Vector3 center;
		Vector3 temp;
		private int mod;
	void start(){
		gos = GameObject.FindGameObjectsWithTag ("Enemy");
		center = transform.position;
	}

	void Update() {
		gos = GameObject.FindGameObjectsWithTag ("Enemy");
		i = 0;
		foreach (GameObject go in gos) {
			i++;
		}
			if (i<maxenemies) {
				mod = i%4;
		    if(i ==0)
				temp = center + 3*Vector3.up;
			if(i ==1)
				temp = center - 3*Vector3.up;
			if(i ==2)
				temp = center + 3*Vector3.left;
			if(i ==3)
				temp = center + 3*Vector3.right;
			    i++;
				Rigidbody clone = Instantiate(projectile, temp, transform.rotation)as Rigidbody;
			}
		}
	}