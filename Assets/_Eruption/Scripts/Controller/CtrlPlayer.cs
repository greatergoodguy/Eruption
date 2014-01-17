using UnityEngine;
using System.Collections;

public class CtrlPlayer : Ctrl_Base {
	
	GameObject goPlayerBase;
	
	void Awake() {
		goPlayerBase = transform.FindChildAsGameObject_BB("Player Base");
	}
	
	public GameObject GetGOPlayerBase() {
		return goPlayerBase;	
	}
}
