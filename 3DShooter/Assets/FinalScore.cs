using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinalScore : MonoBehaviour {

	public static int score;
	TextMesh Text;
	
	
	void Awake () {
		Debug.Log (score);
		Text = GetComponent <TextMesh>();
		score = ScoreManager.hiddenscore;
		Debug.Log (score);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Total Score: " + score);
		Text.text = "Total Score: " + score;
	}
}

