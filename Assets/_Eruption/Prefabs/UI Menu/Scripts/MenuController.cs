using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {
	
	MainMenu mainMenuC;
	PauseMenu pauseMenuC;
	
	void Start () {
		mainMenuC = GetComponent<MainMenu>();	
		pauseMenuC = GetComponent<PauseMenu>();	
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			if(!mainMenuC.IsGuiOn()){
				if(pauseMenuC.IsGuiOn())
					pauseMenuC.TurnGuiOff();
				else
					pauseMenuC.TurnGuiOn();
			}
		}
	}
	
	public bool isMenuOn(){
		return (pauseMenuC.IsGuiOn() || mainMenuC.IsGuiOn());
	}
}
