using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class MacroCommand : Command {

	private GameObject _player;
	private List<Command> _commands;
	private int _index;

	public MacroCommand(GameObject player) {
		_player = player;
		_commands = new List<Command>();
		_index = 0;
	}

	public void addCommand(Command command){
		_commands.Add (command);
	}

	public void execute(){
		Debug.Log (_index);
		_commands [_index].execute ();
		_index += 1;
	}


	public bool hasNext(){
		if (_commands.Count == 0) {
			return false;
		} else if (_index % _commands.Count == 0) {
			_index = 0;
			return false;
		} else {
			return true;
		}
	}
}
