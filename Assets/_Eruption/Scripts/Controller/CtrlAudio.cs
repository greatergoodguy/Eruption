using UnityEngine;
using System.Collections;

public class CtrlAudio : Ctrl_Base {
	
	CtrlPlayer ctrlPlayer;
	
	AudioSource asSFXPlayerRunning; 
	
	void Start () {
		ctrlPlayer = FactoryOfControllers.GetCtrlPlayer();
		
		string sfxPlayerRunningString = "SFX Player Running";
		Transform sfxPlayerRunningT = transform.FindChild_BB(sfxPlayerRunningString);
		asSFXPlayerRunning = transform.FindChild_BB(sfxPlayerRunningString).GetComponent<AudioSource>();
		
		ctrlPlayer.AddTransformToPlayerBase(sfxPlayerRunningT);
	}
		
	public void SFX_PlayerRunning_Play(){		asSFXPlayerRunning.Play();}
	public void SFX_PlayerRunning_Pause(){		asSFXPlayerRunning.Pause();}
	public void SFX_PlayerRunning_Stop(){		asSFXPlayerRunning.Stop();}
	public bool SFX_PlayerRunning_IsPlaying(){	return asSFXPlayerRunning.isPlaying;}
	
}
