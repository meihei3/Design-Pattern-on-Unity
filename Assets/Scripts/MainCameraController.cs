using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour {
	
	[SerializeField]
	private GameObject _target;
	private Vector3 _offset;

	// Use this for initialization
	void Start () {

		_offset = transform.position - _target.transform.position;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {

		transform.position = _target.transform.position + _offset;

	}
}
