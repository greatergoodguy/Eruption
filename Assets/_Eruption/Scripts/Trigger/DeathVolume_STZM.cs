using UnityEngine;
using System.Collections;

public class DeathVolume_STZM : MonoBehaviour {
	
	CtrlPlayer ctrlPlayer;
	
	void Start() {
		ctrlPlayer = FactoryOfControllers.GetCtrlPlayer();
	}
	
	void OnTriggerEnter(Collider other) {	
		if(ctrlPlayer.HasControl()) {
			ctrlPlayer.PlayerDeath();	
		}
	}
}

