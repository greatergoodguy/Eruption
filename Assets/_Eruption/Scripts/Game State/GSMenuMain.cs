using UnityEngine;
using System.Collections;

public class GSMenuMain : GS_Base {
	
	CtrlMenuMain ctrlMenuMain;
	
	public GSMenuMain() {
		ctrlMenuMain = FactoryOfControllers.GetCtrlMenuMain();
	}
	
	public override void StartState () {
		base.StartState ();
		
		ctrlMenuMain.SetDelButtonStart(ctrlMenuMain.SetActiveFalse);
		ctrlMenuMain.SetDelButtonQuit(Application.Quit);
	}
	
	public override bool IsFinished() {
		return false;
	}
        
	public override IGameState GetNextGameState() {
		return GameFlow.gsMock;
	}
}
