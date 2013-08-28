using UnityEngine;
using System.Collections;

public class SFXController : MonoBehaviour {

	AudioSource backgroundRumbleAS;
	AudioSource deathAS;
	AudioSource geyserEruptAS;
	AudioSource lakeWavesAS;
	AudioSource lavaAS;
	AudioSource rockSmashAS;
	AudioSource runningAS;
	AudioSource runningFasterAS;
	AudioSource volcanoEruptionAS;
	AudioSource waterSplashAS;
	
	void Start () {
		AudioSource[] audios = GetComponents<AudioSource>();
		
		backgroundRumbleAS = audios[0];
		deathAS = audios[1];
		geyserEruptAS = audios[2];
		lakeWavesAS = audios[3];
		lavaAS = audios[4];
		rockSmashAS = audios[5];
		runningAS = audios[6];
		runningFasterAS = audios[7];
		volcanoEruptionAS = audios[8];
		waterSplashAS = audios[9];
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
			PlayBackgroundRumble();
		if(Input.GetKeyDown(KeyCode.Alpha2))
			PlayDeath();
		if(Input.GetKeyDown(KeyCode.Alpha3))
			PlayGeyserErupt();
		if(Input.GetKeyDown(KeyCode.Alpha4))
			PlayLakeWaves();
		if(Input.GetKeyDown(KeyCode.Alpha5))
			PlayLava();
		if(Input.GetKeyDown(KeyCode.Alpha6))
			PlayRockSmash();
		if(Input.GetKeyDown(KeyCode.Alpha7))
			PlayRunning();
		if(Input.GetKeyDown(KeyCode.Alpha8))
			PlayRunningFaster();
		if(Input.GetKeyDown(KeyCode.Alpha9))
			PlayVolcanoEruption();
		if(Input.GetKeyDown(KeyCode.Alpha0))
			PlayWaterSplash();
	}
	
	public void PlayBackgroundRumble(){	backgroundRumbleAS.Play();}
	public void PlayDeath(){			deathAS.Play();}
	public void PlayGeyserErupt(){		geyserEruptAS.Play();}
	public void PlayLakeWaves(){		lakeWavesAS.Play();}
	public void PlayLava(){				lavaAS.Play();}
	public void PlayRockSmash(){		rockSmashAS.Play();}
	public void PlayRunning(){			runningAS.Play();}
	public void PlayRunningFaster(){	runningFasterAS.Play();}
	public void PlayVolcanoEruption(){	volcanoEruptionAS.Play();}
	public void PlayWaterSplash(){		waterSplashAS.Play();}
}
