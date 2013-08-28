using UnityEngine;
using System.Collections;



public class ShowHideOnView_STZM : MonoBehaviour {
	
	
	public enum ButtonVisibility { None, Start, Quit };
	public ButtonVisibility buttonVisibility;
	
	public MeshRenderer startHighlightRenderer;
	public MeshRenderer quitHighlightRenderer;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		switch (buttonVisibility) {
		case ButtonVisibility.None:
			startHighlightRenderer.enabled = false;
			quitHighlightRenderer.enabled = false;
			break;
		case ButtonVisibility.Start:
			startHighlightRenderer.enabled = true;
			quitHighlightRenderer.enabled = false;
			break;
		case ButtonVisibility.Quit:
			startHighlightRenderer.enabled = false;
			quitHighlightRenderer.enabled = true;
			break;
		default:
			startHighlightRenderer.enabled = false;
			quitHighlightRenderer.enabled = false;
			break;
		}
//		if (Camera.current.ViewportPointToRay(new Vector3(0.5f, 0.5f, 1.0f)) )
//			this.		
	}
	
	public void SetVisibility(ButtonVisibility buttonVisibility){
		this.buttonVisibility = buttonVisibility;
		
		print ("qwe");
	}
}
