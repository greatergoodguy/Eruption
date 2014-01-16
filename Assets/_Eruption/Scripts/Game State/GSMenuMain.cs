using UnityEngine;
using System.Collections;

public class GSMenuMain : GS_Base {
	
	CtrlMenuPause ctrlMenuPause;
	
	public GSMenuMain() {
		ctrlMenuPause = FactoryOfControllers.GetCtrlMenuPause();
	}
	
	public override void StartState () {
		base.StartState ();
		
		ctrlMenuPause.SetActive(true);
	}
	
	public override bool IsFinished() {
		return false;
	}
        
	public override IGameState GetNextGameState() {
		return GameFlow.gsMock;
	}
}
