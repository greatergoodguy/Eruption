using UnityEngine;
using System.Collections;

public class CtrlMenuMain : MonoBehaviour {

	private bool isPlayButtonSelected = true;
	
	private bool isGuiOn = true;
	
	private GameObject playerGO;
	private FollowCam2D_STZM followCam2D;
	
	private MenuPauseMeshRenderers meshRenderers;
	
	void Start () {
		playerGO = GameObject.Find("Player");
		followCam2D = GameObject.Find("OVRCameraController_STZM").GetComponent<FollowCam2D_STZM>();
		
		meshRenderers = GameObject.Find ("Start Quit Sign").GetComponent<MenuPauseMeshRenderers>();
		
		meshRenderers.showHighlightStart();
		
		TurnGuiOn();
	}
	
	// Update is called once per frame
	void Update () {
		if(isGuiOn){
			if(Input.GetKeyDown(KeyCode.UpArrow)){
				isPlayButtonSelected = true;
				meshRenderers.showHighlightStart();
			}
			if(Input.GetKeyDown(KeyCode.DownArrow)){
				isPlayButtonSelected = false;
				meshRenderers.showHighlightQuit();
			}
			
			if(Input.GetKeyDown(KeyCode.Return) && isPlayButtonSelected)
				TurnGuiOff();
			else if(Input.GetKeyDown(KeyCode.Return) && !isPlayButtonSelected)
				Application.Quit();
		}
	}
	
	public bool IsGuiOn(){		return isGuiOn;}
	public void TurnGuiOn(){	
		isGuiOn = true;
		if(followCam2D != null || gameObject != null)
			followCam2D.SetTarget(transform, true);
		Time.timeScale = 0;
	}
	public void TurnGuiOff(){	
		isGuiOn = false;
		followCam2D.SetTarget(playerGO.transform, false);
		Time.timeScale = 1;
	}
}
