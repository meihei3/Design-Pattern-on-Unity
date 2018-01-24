using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private GameObject _player;

	// command
	private Command _button_Left;
	private Command _button_Right;
	private Command _button_Empty;


	// Use this for initialization
	void Start () {
		_button_Left = new MoveLeftCommand(_player);
		_button_Right = new MoveRightCommand (_player);
		_button_Empty = new IdleCommand (_player);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			if (Input.GetKey ("right")) {
				_button_Right.execute ();
			}
			if (Input.GetKey ("left")) {
				_button_Left.execute ();
			}

		} else {
			_button_Empty.execute ();
		}
	}
}
