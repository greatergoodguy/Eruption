using UnityEngine;
using System.Collections;

public class GSLevelVolcano : GS_Base {
	
	CtrlCamera ctrlCamera;
	
	public GSLevelVolcano() {
		ctrlCamera = FactoryOfControllers.GetCtrlCamera();
	}
	
	public override void StartState () {
		base.StartState ();
		
		ctrlCamera.TrackPlayer();
	}
	
	public override void ExitState () {
		base.ExitState ();
	}
	
	public override bool IsFinished() {
		return false;
	}
        
	public override IGameState GetNextGameState() {
		return GameFlow.gsMock;
	}
}