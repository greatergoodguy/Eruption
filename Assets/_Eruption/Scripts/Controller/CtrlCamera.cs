using UnityEngine;
using System.Collections;

public class CtrlCamera : Ctrl_Base {
	
	
	Transform tPositionMenuMain;
	Transform tPositionUndefined;
	
	Transform tCameraContainer;
	FollowCam2D_BB followCam2D;
	
	void Awake() {
		tPositionMenuMain = transform.FindChild_BB("Position Menu Main");
		tPositionUndefined = transform.FindChild_BB("Position Undefined");
		
		tCameraContainer = transform.FindChild_BB("OVRCameraController_BB");
		followCam2D = tCameraContainer.GetComponent<FollowCam2D_BB>();
	}
	

	public void Track(Transform t) {
		followCam2D.SetTarget(t);
	}
	
	public void SetPositionMenuMain() {
		tCameraContainer.position = tPositionMenuMain.position;
	}
	
	public void SetPositionUndefined() {
		tCameraContainer.position = tPositionUndefined.position;
	}
}
