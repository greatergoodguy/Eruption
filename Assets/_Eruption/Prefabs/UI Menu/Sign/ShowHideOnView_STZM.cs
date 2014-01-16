using UnityEngine;
using System.Collections;

public class ShowHideOnView_STZM : MonoBehaviour {
	
	
	public enum ButtonVisibility { None, Start, Quit };
	public ButtonVisibility buttonVisibility;
	
	public MeshRenderer startHighlightRenderer;
	public MeshRenderer quitHighlightRenderer;
	
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
	}
	
	public void SetVisibility(ButtonVisibility buttonVisibility){
		this.buttonVisibility = buttonVisibility;
	}
}
