using UnityEngine;
using System.Collections;

public class CtrlCamera : Ctrl_Base {
	
	Transform tCameraContainer;
	
	Transform tPositionMenuMain;
	Transform tPositionUndefined;
	
	Transform tPlayerBase;
	FollowCam2D_BB followCam2D;
	
	void Awake() {
		tCameraContainer = transform.FindChild_BB("OVRCameraController_STZM");
		
		tPositionMenuMain = transform.FindChild_BB("Position Menu Main");
		tPositionUndefined = transform.FindChild_BB("Position Undefined");
		
		CtrlPlayer ctrlPlayer = FactoryOfControllers.GetCtrlPlayer();
		tPlayerBase = ctrlPlayer.GetTransformPlayerBase();
		followCam2D = GameObject.Find("OVRCameraController_STZM").GetComponent<FollowCam2D_BB>();
	}
	
	public void TrackPlayer() {
		followCam2D.SetTarget(tPlayerBase, false);
	}
	
	public void SetPositionMenuMain() {
		tCameraContainer.position = tPositionMenuMain.position;
	}
	
	public void SetPositionUndefined() {
		tCameraContainer.position = tPositionUndefined.position;
	}
}
