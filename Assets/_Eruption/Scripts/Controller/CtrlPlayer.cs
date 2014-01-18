using UnityEngine;
using System.Collections;

public class CtrlPlayer : Ctrl_Base {
	
	Transform tPlayerBase;
	
	void Awake() {
		tPlayerBase = transform.FindChild_BB("Player Base");
	}
	
	public Transform GetTransformPlayerBase() {
		return tPlayerBase;	
	}
	
	public void AddTransformToPlayerBase(Transform otherTransform) {
		otherTransform.parent = tPlayerBase;
	}
}
