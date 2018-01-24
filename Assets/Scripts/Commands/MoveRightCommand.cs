using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class MoveRightCommand : Command{

	private GameObject _player;
	private Animator _animator;

	public MoveRightCommand(GameObject player){
		_player = player;
		_animator = _player.GetComponent<Animator> ();
	}

	public void execute(){
		_player.transform.rotation = Quaternion.Euler(0, 90, 0);
		_player.transform.position += _player.transform.forward * 0.05f;
		_animator.SetBool ("is_walk", true);
	}

}