using UnityEngine;
using System.Collections;

public class damage : MonoBehaviour {
	public int currenthealth = 5;
	public GameObject bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == bullet.tag) {
			currenthealth = currenthealth - 1;
			if (currenthealth <= 0){
				//logic for respawning player at origin with full health and score penalty
				//cannot destroy object, next line causes game to crash.
				Destroy (gameObject);}
		}}}