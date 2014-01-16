using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {
	
	MainMenu mainMenuC;
	PauseMenu pauseMenuC;
	
	void Start () {
		mainMenuC = GetComponent<MainMenu>();	
		pauseMenuC = GetComponent<PauseMenu>();	
	}
	
	public bool isMenuOn(){
		return (pauseMenuC.IsGuiOn() || mainMenuC.IsGuiOn());
	}
}
