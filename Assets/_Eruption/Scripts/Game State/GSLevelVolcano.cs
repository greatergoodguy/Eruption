using UnityEngine;
using System.Collections;

public class GSLevelVolcano : GS_Base {
	
	CtrlAudio ctrlAudio;
	CtrlPlayer ctrlPlayer;
	CtrlCamera ctrlCamera;
	
	public GSLevelVolcano() {
		ctrlAudio = FactoryOfControllers.GetCtrlAudio();
		ctrlPlayer = FactoryOfControllers.GetCtrlPlayer();
		ctrlCamera = FactoryOfControllers.GetCtrlCamera();
	}
	
	public override void StartState () {
		base.StartState ();
		
		ctrlAudio.Music_Play_Volcano();
		ctrlCamera.Track(ctrlPlayer.GetTransformPlayerBase());
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