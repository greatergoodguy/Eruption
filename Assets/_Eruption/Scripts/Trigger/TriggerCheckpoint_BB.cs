using UnityEngine;
using System.Collections;

public class TriggerCheckpoint_BB : MonoBehaviour {
	
	CtrlPlayer ctrlPlayer;
	
	void Start() {
		ctrlPlayer = FactoryOfControllers.GetCtrlPlayer();
	}
	
	void OnTriggerEnter(Collider other) {	
		ctrlPlayer.SetRespawnPoint(transform.position);
	}
}