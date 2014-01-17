using UnityEngine;
using System.Collections;

public class CtrlMenuMain : MonoBehaviour {
	
	DelButton delButtonStart = UtilMock.MockFunction;
	DelButton delButtonQuit = UtilMock.MockFunction;
	
	MenuMainMeshRenderers meshRenderers;
	
	bool isPlayButtonSelected = true;
	bool isActive = true;
	
	void Start () {
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
		Time.timeScale = 0;
	}
	
	public void SetActiveFalse(){	
		isActive = false;
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
