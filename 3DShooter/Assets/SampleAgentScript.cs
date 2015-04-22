﻿using UnityEngine;
using System.Collections;

public class SampleAgentScript : MonoBehaviour {
	public int seekrad = 20;
	public Transform target;
	NavMeshAgent agent;
	public int health = 5;
	private int currenthealth;
	public GameObject bullet;
<<<<<<< HEAD
	public GameObject shells;
	public int explosionsize = 100;
	int i = 0;
	private Vector3 x;
	private Quaternion y;
	private Rigidbody clone;
	private int state = 1;
	public bool fire = false;
	Vector3 randomDirection;
	public int walkRadius;
=======
	public int scoreValue = 10;
	public int levelValue = 2500;

>>>>>>> origin/master
	// Use this for initialization
	void Start () {
		currenthealth = health + LevelManager.level;
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 randomDirection = Random.insideUnitSphere * walkRadius;
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		RaycastHit hit;
		if (Physics.Raycast (transform.position, fwd, out hit))
		//FSM, 1 = seek, 0 = target aquired, 2 is roam
		if (hit.collider.name == target.name)
			state = 0;
			if (state == 1) {
				if ((agent.transform.position - target.position).magnitude > seekrad)
					agent.SetDestination (target.position);
				else {
					agent.SetDestination (agent.transform.position);
					state = 2;
				}
			} else if (state == 2) {
				if ((agent.transform.position - target.position).magnitude < (seekrad + 25)) {
					randomDirection += transform.position;
					NavMeshHit store;
					NavMesh.SamplePosition (randomDirection, out store, walkRadius, 1);
					Vector3 finalPosition = store.position;
				} else
					state = 1;
			} else if (state == 0) {
				agent.SetDestination (target.position);
				if (hit.collider.name == target.name)
					fire = true;
				else
					fire = false;
			}
		}

	void OnTriggerEnter(Collider other) {
		if (other.tag == bullet.tag) {
			currenthealth = currenthealth - 1;
			if (currenthealth <= 0){
<<<<<<< HEAD
				x = agent.transform.position;
				y = agent.transform.rotation;
				Destroy (gameObject);
				for (i = 0; i<explosionsize; i++)
				Instantiate(shells, x, y);
			}
		}
=======

				ScoreManager.score += scoreValue;
				Destroy (gameObject);
				if ((ScoreManager.score / LevelManager.level) > levelValue){
					LevelManager.level += 1;
				}

			}
		} else
			Debug.Log (other.tag);
>>>>>>> origin/master
	}
}
