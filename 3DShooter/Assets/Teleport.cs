using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public GameObject player;
	public Transform cap;
	public Vector3 Center;
	public int maxDist;
	// Use this for initialization
	void OnTriggerEnter(Collider 	other) {
		if (other.tag == player.tag) {
			cap.position = Center + Random.insideUnitSphere * maxDist;
		}
		}
}

