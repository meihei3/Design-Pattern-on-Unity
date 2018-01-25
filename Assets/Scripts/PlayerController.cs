using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PlayerController {

	private CommandStack _commands;
	private State _player_state;

	public PlayerController(GameObject player){
		_commands = new CommandStack();
		_player_state = player.GetComponent<State> ();
	}

	public void execute(){
		if (!_commands.isEmpty ()) {
			Debug.Log (_commands [0]);
			var command = _commands.pop ();
			if (command is MacroCommand) {
				var Mcommand = command as MacroCommand;
				if (Mcommand.hasNext ()) {
					_commands.Insert (0, Mcommand);
				}
				Mcommand.execute ();
			} else {
				command.execute ();
			}
		}
	}

	public void addNext(Command command){
		_commands.pushBack (command);
	}

}
