using UnityEngine;
using System.Collections;

public class Leveltrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void ontriggerenter(Collider other){ Application.LoadLevel("Simple level");}
}
