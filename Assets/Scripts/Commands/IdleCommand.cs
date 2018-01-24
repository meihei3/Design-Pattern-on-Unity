using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class IdleCommand : Command{

	private GameObject _player;
	private Animator _animator;

	public IdleCommand(GameObject player){
		_player = player;
		_animator = _player.GetComponent<Animator> ();
	}

	public void execute(){
		_animator.SetBool ("is_walk", false);
	}

}