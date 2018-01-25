using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : Command {

	private GameObject _player;
	// private Animator _animator;
	private Rigidbody _rigidbody;
	private Vector3 _jump;

	public JumpCommand(GameObject player){
		_player = player;
		// _animator = _player.GetComponent<Animator> ();
		_rigidbody = player.GetComponent<Rigidbody> ();
		_jump = new Vector3 (0, 4, 0);
	}

	public void execute(){
		_rigidbody.velocity = _jump;
		// _animator.SetBool ("is_jumping", true);
	}

}
