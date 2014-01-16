using UnityEngine;
using System.Collections;

public class GSInitializeGame : GS_Base {

	public override bool IsFinished() {
		return true;
	}
        
	public override IGameState GetNextGameState() {
		return GameFlow.gsMenuMain;
	}
}
