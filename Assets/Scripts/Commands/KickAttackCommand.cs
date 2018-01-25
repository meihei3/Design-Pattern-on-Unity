using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickAttackCommand : Command {

	private GameObject _player;
	// private Animator _animator;

	public KickAttackCommand(GameObject player){
		_player = player;
		// _animator = _player.GetComponent<Animator> ();
	}

	public void execute(){
		// _animator.SetBool ("is_attack_2", true);
		Debug.Log("Kick attacked!!!");
	}

}
