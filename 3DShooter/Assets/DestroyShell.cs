﻿using UnityEngine;
using System.Collections;

public class DestroyShell : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.name == "Shell(Clone)"){
			Destroy(gameObject, 5);
		}
	}
}
