using UnityEngine;
using System.Collections;

public class SampleAgentScript : MonoBehaviour {
	public int seekrad;
	public Transform target;
	NavMeshAgent agent;
	public int health = 5;
	private int currenthealth;
	public GameObject bullet;
	public int scoreValue = 10;
	public int levelValue = 2500;

	// Use this for initialization
	void Start () {
		currenthealth = health + LevelManager.level;
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((agent.transform.position - target.position).magnitude > seekrad)
		agent.SetDestination (target.position);
		else agent.SetDestination (agent.transform.position);
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == bullet.tag) {
			currenthealth = currenthealth - 1;
			if (currenthealth <= 0){

				ScoreManager.score += scoreValue;
				Destroy (gameObject);
				if ((ScoreManager.score / LevelManager.level) > levelValue){
					LevelManager.level += 1;
				}

			}
		} else
			Debug.Log (other.tag);
	}
}
