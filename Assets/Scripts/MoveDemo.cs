using UnityEngine;
using System.Collections;

public class MoveDemo : MonoBehaviour {

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")) {
			transform.position += transform.forward * 0.05f;
		}
		if (Input.GetKey("right")) {
			transform.rotation = Quaternion.Euler(0, 90, 0);
		}
		if (Input.GetKey ("left")) {
			transform.rotation = Quaternion.Euler(0, -90, 0);
		}
	}
}