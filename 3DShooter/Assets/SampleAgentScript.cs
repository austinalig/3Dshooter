using UnityEngine;
using System.Collections;

public class SampleAgentScript : MonoBehaviour {
	public int seekrad = 20;
	public GameObject target;
	NavMeshAgent agent;
	public int health = 5;
	private int currenthealth;
	public GameObject bullet;
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
	public int scoreValue = 10;
	public int levelValue = 2500;
	public float random;


	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player");
		currenthealth = health + LevelManager.level;
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		random = Time.time;
		Vector3 randomDirection = Random.insideUnitSphere * walkRadius;
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		RaycastHit hit;
		if (Physics.Raycast (transform.position, fwd, out hit))
			//FSM, 1 = seek, 0 = target aquired, 2 is roam
			if (hit.collider.tag == target.tag)
				state = 0;
		if (state == 1) {
			if ((agent.transform.position - target.transform.position).magnitude > seekrad)
				agent.SetDestination (target.transform.position);
			else {
				agent.SetDestination (agent.transform.position);
				state = 2;
			}
		} else if (state == 2) {
			if ((agent.transform.position - target.transform.position).magnitude < (seekrad + 25)) {
				randomDirection = (random * Vector3.up) + (random * Vector3.left);
				agent.SetDestination(randomDirection);
			} else
				state = 1;
		} else if (state == 0) {
			agent.SetDestination (target.transform.position);
			if (hit.collider.name == target.name)
				fire = true;
			else
				fire = false;
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == bullet.tag) {
			currenthealth = currenthealth - 1;
			state = 0;
			if (currenthealth <= 0){
				x = agent.transform.position;
				y = agent.transform.rotation;
				Destroy (gameObject);
				for (i = 0; i<explosionsize; i++)
					Instantiate(shells, x, y);
				ScoreManager.score += scoreValue;
				ScoreManager.hiddenscore += scoreValue;
				if ((ScoreManager.hiddenscore / LevelManager.level) > levelValue){
					LevelManager.level += 1;
				}
				
			}
		}
	}
}

