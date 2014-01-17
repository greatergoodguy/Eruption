using UnityEngine;
using System.Collections;

public class GSMenuMain : GS_Base {
	
	CtrlMenuMain ctrlMenuMain;
	CtrlCamera ctrlCamera;
	
	bool isFinished;
	
	public GSMenuMain() {
		ctrlMenuMain = FactoryOfControllers.GetCtrlMenuMain();
		ctrlCamera = FactoryOfControllers.GetCtrlCamera();
	}
	
	public override void StartState () {
		base.StartState ();
		
		ctrlCamera.SetPositionMenuMain();
		
		ctrlMenuMain.SetActiveTrue();
		ctrlMenuMain.SetDelButtonStart(Start);
		ctrlMenuMain.SetDelButtonQuit(Application.Quit);
		
		isFinished = false;
	}
	
	public override void ExitState () {
		base.ExitState();
		ctrlMenuMain.SetActiveFalse();
	}
	
	public override bool IsFinished() {
		return isFinished;
	}
        
	public override IGameState GetNextGameState() {
		return GameFlow.gsLevelVolcano;
	}
	
	void Start() {
		ctrlMenuMain.SetActiveFalse();
		isFinished = true;
	}
}
