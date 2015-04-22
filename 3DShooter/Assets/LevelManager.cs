using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public static int level;
	
	Text text;
	

	void Awake () {
		
		text = GetComponent <Text>();
		level = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Level: " + level;
		
	}
}
