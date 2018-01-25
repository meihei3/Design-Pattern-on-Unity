using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	[SerializeField]
	private GameObject _player;

	// command
	private Command _button_Left;
	private Command _button_Right;
	private Command _button_Empty;
	private Command _button_Z;
	private Command _button_X;
	private Command _button_Space;

	private bool _is_jumping = false;

	// Use this for initialization
	void Start () {
		_button_Left = new MoveLeftCommand(_player);
		_button_Right = new MoveRightCommand (_player);
		_button_Empty = new IdleCommand (_player);
		_button_Z = new PunchAttackCommand (_player);
		_button_X = new KickAttackCommand (_player);
		_button_Space = new JumpCommand (_player);
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
			if (Input.GetKeyDown ("z")) {
				_button_Z.execute ();
				_button_Empty.execute ();
				_button_Z.execute ();
			} else if (Input.GetKeyDown ("x")) {
				_button_X.execute ();
			} 

			if (Input.GetKeyDown ("space")) {
				if (!_is_jumping) {
					_button_Space.execute ();
					_is_jumping = true;
				} 
			} else if (_is_jumping) {
				_button_Empty.execute ();
				_is_jumping = false;
			}
		} else {
			_button_Empty.execute ();
		}
	}
}
