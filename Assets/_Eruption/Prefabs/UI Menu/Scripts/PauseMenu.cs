using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
	public Texture resumeButtonTexture;
	public Texture restartButtonTexture;
	
	private bool isResumeButtonSelected = true;
	
	private bool isGuiOn = false;
	
	void Start () {
		TurnGuiOff();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
			isResumeButtonSelected = true;
		if(Input.GetKeyDown(KeyCode.DownArrow))
			isResumeButtonSelected = false;
		
		if(Input.GetKeyDown(KeyCode.Return) && isResumeButtonSelected)
			TurnGuiOff();
		else if(Input.GetKeyDown(KeyCode.Return) && !isResumeButtonSelected)
			Application.LoadLevel(0);
	}
	
	void OnGUI(){
		if(!isGuiOn){
			return;	
		}
		
		
		if(isResumeButtonSelected)
			GuiUtilsOR.GUIStereoTexture(70, 70, 500, 500, resumeButtonTexture);
		else
			GuiUtilsOR.GUIStereoTexture(70, 70, 500, 500, restartButtonTexture);
	}
	
	public bool IsGuiOn(){		return isGuiOn;}
	public void TurnGuiOn(){	
		Time.timeScale = 0;
		isGuiOn = true;
		isResumeButtonSelected = true;
	}
	public void TurnGuiOff(){	
		Time.timeScale = 1;
		isGuiOn = false;
	}
}
