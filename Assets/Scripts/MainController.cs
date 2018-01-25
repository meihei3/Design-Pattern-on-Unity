using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	[SerializeField]
	private GameObject _player_Object;

	// command
	private PlayerController _player_Action;
	private Command _button_Left;
	private Command _button_Right;
	private Command _button_Empty;
	private Command _button_Z;
	private Command _button_X;
	private Command _button_Space;
	private MacroCommand _button_C;

	private bool _is_jumping = false;
	private float _time_Elapsed = 0.0f;

	// Use this for initialization
	void Start () {
		_button_Left = new MoveLeftCommand(_player_Object);
		_button_Right = new MoveRightCommand (_player_Object);
		_button_Empty = new IdleCommand (_player_Object);
		_button_Z = new PunchAttackCommand (_player_Object);
		_button_X = new KickAttackCommand (_player_Object);
		_button_Space = new JumpCommand (_player_Object);
		_player_Action = new PlayerController (_player_Object);

		_button_C = new MacroCommand (_player_Object);
		_button_C.addCommand (_button_X);
		_button_C.addCommand (_button_Z);
	}
	
	// Update is called once per frame
	void Update () {
		inputHandler ();
		_player_Action.execute ();

	}

	private void inputHandler(){
		if (Input.anyKey) {
			if (Input.GetKey ("right")) {
				_player_Action.addNext (_button_Right);
			}
			if (Input.GetKey ("left")) {
				_player_Action.addNext (_button_Left);
			}
			if (Input.GetKeyDown ("z")) {
				_player_Action.addNext (_button_Z);
			} else if (Input.GetKeyDown ("x")) {
				_player_Action.addNext (_button_X);
			} else if (Input.GetKeyDown ("c")) {
				_player_Action.addNext(_button_C);
			}

			if (Input.GetKeyDown ("space")) {
				if (!_is_jumping) {
					_player_Action.addNext (_button_Space);
				} 
			} else if (_is_jumping) {
				_player_Action.addNext (_button_Empty);
			}
		} else {
			_time_Elapsed += Time.deltaTime;
			if (_time_Elapsed >= 1.0f) {
				_player_Action.addNext (_button_Empty);
				_time_Elapsed = 0.0f;
			}
		}
	}
}
