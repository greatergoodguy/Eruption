using UnityEngine;
using System.Collections;

public class MenuPauseMeshRenderers : MonoBehaviour {
	
	public MeshRenderer mrHighlightStart;
	public MeshRenderer mrHighlightQuit;
	
	public void showHighlightStart() {
		mrHighlightStart.enabled = true;
		mrHighlightQuit.enabled = false;
	}
	
	public void showHighlightQuit() {
		mrHighlightStart.enabled = false;
		mrHighlightQuit.enabled = true;
	}
}
