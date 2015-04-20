using UnityEngine;
using System.Collections;

public class DestroyBullet : MonoBehaviour {
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(gameObject.name == "Bullet(Clone)")
		{Destroy(gameObject, 5);
		}
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == enemy.tag)
			Destroy (gameObject);
			else Debug.Log (other.tag);
	}
}
