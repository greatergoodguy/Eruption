using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public Texture playButtonTexture;
	public Texture quitButtonTexture;
	public Texture leftArrowTexture;
	
	private bool isPlayButtonSelected = true;
	
	private bool isGuiOn = true;
	
	private GameObject uiMenuGO;
	private GameObject playerGO;
	private FollowCam2D_STZM followCam2D;
	
	private ShowHideOnView_STZM showHideOnView;
	
	void Start () {
		uiMenuGO = GameObject.Find("UI Menu");
		playerGO = GameObject.Find("Player");
		followCam2D = GameObject.Find("OVRCameraController_STZM").GetComponent<FollowCam2D_STZM>();
		
		showHideOnView = GameObject.Find ("Start Quit Sign").GetComponent<ShowHideOnView_STZM>();
		
		TurnGuiOn();
	}
	
	// Update is called once per frame
	void Update () {
		if(isGuiOn){
			if(Input.GetKeyDown(KeyCode.UpArrow)){
				isPlayButtonSelected = true;
				showHideOnView.SetVisibility(ShowHideOnView_STZM.ButtonVisibility.Start);
			}
			if(Input.GetKeyDown(KeyCode.DownArrow)){
				isPlayButtonSelected = false;
				showHideOnView.SetVisibility(ShowHideOnView_STZM.ButtonVisibility.Quit);
			}
			
			if(Input.GetKeyDown(KeyCode.Return) && isPlayButtonSelected)
				TurnGuiOff();
			else if(Input.GetKeyDown(KeyCode.Return) && !isPlayButtonSelected)
				Application.Quit();
		}
	}
	
	/*
	void OnGUI(){
		if(!isGuiOn){
			return;	
		}
		
		GuiUtilsOR.GUIStereoTexture(200, 150, 200, 100, playButtonTexture);
		GuiUtilsOR.GUIStereoTexture(200, 260, 200, 100, quitButtonTexture);
		
		if(isPlayButtonSelected)
			GuiUtilsOR.GUIStereoTexture(400, 150, 200, 100, leftArrowTexture);
		else
			GuiUtilsOR.GUIStereoTexture(400, 260, 200, 100, leftArrowTexture);
	}
	*/
	
	public bool IsGuiOn(){		return isGuiOn;}
	public void TurnGuiOn(){	
		isGuiOn = true;
		if(followCam2D != null || uiMenuGO != null)
			followCam2D.SetTarget(uiMenuGO.transform, true);
		Time.timeScale = 0;
	}
	public void TurnGuiOff(){	
		isGuiOn = false;
		followCam2D.SetTarget(playerGO.transform, false);
		Time.timeScale = 1;
	}
}
