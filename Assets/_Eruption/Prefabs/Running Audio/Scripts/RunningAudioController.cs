using UnityEngine;
using System.Collections;

public class RunningAudioController : MonoBehaviour {
	
	AudioSource runningAS; 
	
	void Start () {
		runningAS = GetComponent<AudioSource>();
	}
	
	public void Play(){			runningAS.Play();}
	public void Pause(){		runningAS.Pause();}
	public void Stop(){			runningAS.Stop();}
	public bool IsPlaying(){	return runningAS.isPlaying;}
}
