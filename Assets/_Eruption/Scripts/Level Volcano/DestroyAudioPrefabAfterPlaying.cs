using UnityEngine;
using System.Collections;

public class DestroyAudioPrefabAfterPlaying : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(!audio.isPlaying){
			Destroy(gameObject);	
		}
	}
}
