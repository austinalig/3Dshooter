using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(gameObject.name == "Bullet(Clone)"){
			Destroy(gameObject, 5);
		}
	}
}
