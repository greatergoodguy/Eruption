using UnityEngine;
using System.Collections;

public static class FactoryOfControllers {
        
	static CtrlMenuPause ctrlMenuPause;
	public static CtrlMenuPause GetCtrlMenuPause() {
		if(ctrlMenuPause == null) {
			ctrlMenuPause = GameObject_BB.Find("UI Menu Pause").GetComponent_BB<CtrlMenuPause>();}
                
		return ctrlMenuPause;
	}
	
	static CtrlMenuMain ctrlMenuMain;
	public static CtrlMenuMain GetCtrlMenuMain() {
		if(ctrlMenuMain == null) {
			ctrlMenuMain = GameObject_BB.Find("UI3D Menu Main").GetComponent_BB<CtrlMenuMain>();}
                
		return ctrlMenuMain;
	}
	
	static CtrlCamera ctrlCamera;
	public static CtrlCamera GetCtrlCamera() {
		if(ctrlCamera == null) {
			ctrlCamera = GameObject_BB.Find("Camera").GetComponent_BB<CtrlCamera>();}
                
		return ctrlCamera;
	}
}