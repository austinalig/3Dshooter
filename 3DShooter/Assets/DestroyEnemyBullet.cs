using UnityEngine;
using System.Collections;

public class DestroyEnemyBullet : MonoBehaviour {
	//public GameObject enemy;
	public int length = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.name == "EnemyBullet(Clone)")
		{Destroy(gameObject, length);
		}
	}
	/*
	void OnTriggerEnter(Collider other) {
		if (other.tag == enemy.tag)
			Destroy (gameObject);
			else Debug.Log (other.tag);
	}*/
}
