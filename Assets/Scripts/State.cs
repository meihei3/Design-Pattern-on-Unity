using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour {

	[SerializeField]
	private bool _is_jumping = false;
	[SerializeField]
	private bool _is_attacking = false;
	[SerializeField]
	private bool _is_idling = false;

	private Animator _animetor;

	// Use this for initialization
	void Start () {
		_animetor = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		_is_idling = false;
		_is_attacking = false;
		var stateInfo = _animetor.GetCurrentAnimatorStateInfo (0);
		if (stateInfo.nameHash == Animator.StringToHash ("Base Layer.Attack-1") || stateInfo.nameHash == Animator.StringToHash ("Base Layer.Attack-2")) {
			_is_attacking = true;
		} else if (stateInfo.nameHash == Animator.StringToHash ("Base Layer.Idle")) {
			_is_idling = true;
		}
	}

	public bool Attacking {
		set { this._is_attacking = value; }
		get { return this._is_attacking; }
	}

	public bool Idling {
		set { this._is_idling = value; }
		get { return this._is_idling; }
	}
}
