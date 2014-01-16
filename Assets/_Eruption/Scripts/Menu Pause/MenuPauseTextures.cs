using UnityEngine;
using System.Collections;

public class MenuPauseTextures : MonoBehaviour {
	
	public Texture texSelectedResume;
	public Texture texSelectedRestart;
	
	void Awake() {
		Assert_BB.Assert(texSelectedResume);
		Assert_BB.Assert(texSelectedRestart);
	}
}
