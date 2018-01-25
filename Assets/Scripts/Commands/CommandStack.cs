using System.Collections;
using System.Collections.Generic;

class CommandStack :List<Command> {

	public void pushBack(Command item){
		base.Add (item);
	}

	public Command peek(){
		return base [0];
	}

	public Command pop(){
		var cmd = peek ();
		base.RemoveAt (0);
		return cmd;
	}

	public bool isEmpty(){
		return base.Count <= 0;
	}
}