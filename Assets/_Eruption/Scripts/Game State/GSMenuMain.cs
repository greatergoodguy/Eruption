using UnityEngine;
using System.Collections;

public class GSMenuMain : GS_Base {
	
	CtrlMenuMain ctrlMenuMain;
	CtrlCamera ctrlCamera;
	
	public GSMenuMain() {
		ctrlMenuMain = FactoryOfControllers.GetCtrlMenuMain();
		ctrlCamera = FactoryOfControllers.GetCtrlCamera();
	}
	
	public override void StartState () {
		base.StartState ();
		
		ctrlCamera.SetPositionMenuMain();
		ctrlMenuMain.SetActiveTrue();
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
