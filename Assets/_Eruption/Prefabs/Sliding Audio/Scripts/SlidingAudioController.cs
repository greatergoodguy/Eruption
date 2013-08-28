using UnityEngine;
using System.Collections;

public class SlidingAudioController : MonoBehaviour {
	
	AudioSource playerSlidingAS; 
	
	void Start () {
		playerSlidingAS = GetComponent<AudioSource>();
	}
	
	public void Play(){			playerSlidingAS.Play();}
	public void Pause(){		playerSlidingAS.Pause();}
	public void Stop(){			playerSlidingAS.Stop();}
	public bool IsPlaying(){	return playerSlidingAS.isPlaying;}
}
