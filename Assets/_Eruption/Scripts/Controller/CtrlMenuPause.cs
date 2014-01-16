using UnityEngine;
using System.Collections;

public class CtrlMenuPause : Ctrl_Base {
	
	MenuPauseTextures textures;
	
	bool isResumeButtonSelected = true;
	bool isVisible = false;
	bool isActive = false;
	
	void Awake() {
		textures = transform.FindChild_BB("Textures").GetComponent_BB<MenuPauseTextures>();
	}
	
	void Start () {
		SetVisibleFalse();
	}
	
	void Update () {
		
		if(!isActive) {
			return;}
		
		if(Input.GetKeyDown(KeyCode.Escape)) {
			SetVisibleTrue();}
		
		if(!isVisible) {
			return;}
		
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			isResumeButtonSelected = true;}
		if(Input.GetKeyDown(KeyCode.DownArrow)) {
			isResumeButtonSelected = false;}
		
		if(Input.GetKeyDown(KeyCode.Return) && isResumeButtonSelected) {
			SetVisibleFalse();}
		else if(Input.GetKeyDown(KeyCode.Return) && !isResumeButtonSelected) {
			Application.LoadLevel(0);}
	}
	
	void OnGUI(){
		if(!isVisible) {
			return;}
		
		if(isResumeButtonSelected) {
			UtilGuiVR.GUIStereoTexture(70, 70, 500, 500, textures.texSelectedResume);}
		else {
			UtilGuiVR.GUIStereoTexture(70, 70, 500, 500, textures.texSelectedRestart);}
	}
	
	public void SetVisibleTrue() {
		
		Time.timeScale = 0;	
		isVisible = true;
			
		isResumeButtonSelected = true;
    }
	
	public void SetVisibleFalse() {
		Time.timeScale = 1;
		isVisible = false;
	}
        
	public bool IsVisible() {
		return isVisible;}
	
	public void SetActive(bool b) {
		isActive = b;}
	
	public bool IsActive() {
		return isActive;}
}