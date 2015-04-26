using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public Vector3 dir;
	public float speed;
	private CharacterController controller;
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKey("up")) || (Input.GetKey("down")) || (Input.GetKey("left")) || (Input.GetKey("right")))
		dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			dir = transform.TransformDirection(dir);

		dir *= speed * Time.fixedDeltaTime;
		controller.Move (dir);
	}
}
