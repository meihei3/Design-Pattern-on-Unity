using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchAttackCommand : Command {

	private GameObject _player;
	private Animator _animator;

	public PunchAttackCommand(GameObject player){
		_player = player;
		_animator = _player.GetComponent<Animator> ();
	}

	public void execute(){
		_animator.SetBool ("is_attack_1", true);
	}

}
