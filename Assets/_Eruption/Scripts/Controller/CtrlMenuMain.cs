using UnityEngine;
using System.Collections;

public class CtrlMenuMain : MonoBehaviour {
	
	DelButton delButtonStart = UtilMock.MockFunction;
	DelButton delButtonQuit = UtilMock.MockFunction;
	
	GameObject playerGO;
	FollowCam2D_STZM followCam2D;
	
	MenuMainMeshRenderers meshRenderers;
	
	bool isPlayButtonSelected = true;
	bool isActive = true;
	
	void Start () {
		playerGO = GameObject.Find("Player");
		followCam2D = GameObject.Find("OVRCameraController_STZM").GetComponent<FollowCam2D_STZM>();
		
		meshRenderers = GameObject.Find ("Start Quit Sign").GetComponent<MenuMainMeshRenderers>();
		
		meshRenderers.showHighlightStart();
		
		SetActiveFalse();
	}
	
	// Update is called once per frame
	void Update () {
		if(isActive){
			if(Input.GetKeyDown(KeyCode.UpArrow)){
				isPlayButtonSelected = true;
				meshRenderers.showHighlightStart();
			}
			if(Input.GetKeyDown(KeyCode.DownArrow)){
				isPlayButtonSelected = false;
				meshRenderers.showHighlightQuit();
			}
			
			if(Input.GetKeyDown(KeyCode.Return) && isPlayButtonSelected) {
				delButtonStart();
			}
			else if(Input.GetKeyDown(KeyCode.Return) && !isPlayButtonSelected) {
				delButtonQuit();
			}
		}
	}
	
	public bool IsActive(){
		return isActive;}
	
	public void SetActiveTrue(){	
		isActive = true;
		if(followCam2D != null || gameObject != null)
			followCam2D.SetTarget(transform, true);
		Time.timeScale = 0;
	}
	
	public void SetActiveFalse(){	
		isActive = false;
		followCam2D.SetTarget(playerGO.transform, false);
		Time.timeScale = 1;
	}
	
	// ==========================
	// Button Delegates
	// ==========================
	public void SetDelButtonStart(DelButton delButtonStart){
		this.delButtonStart = delButtonStart;
	}
	
	public void SetDelButtonQuit(DelButton delButtonQuit){
		this.delButtonQuit = delButtonQuit;
	}
}
