using UnityEngine;
using System.Collections;

public class _MasterScript : MonoBehaviour {
        
	IGameState activeGameState;
        
	void Awake () {
		activeGameState = GameFlow.GetInitialGameState();
	}
        
	void Start () {
		activeGameState.StartState();
	}
        
	void Update () {
		activeGameState.Update();
                
		if(activeGameState.IsFinished()) {
			activeGameState.ExitState();
			activeGameState = activeGameState.GetNextGameState();
			activeGameState.StartState();
		}
	}
}