using UnityEngine;
using System.Collections;

public class CtrlAudio : Ctrl_Base {
	
	CtrlPlayer ctrlPlayer;
	
	
	AudioSource asMusicVolcano;
	AudioSource asSFXPlayerRunning; 
	
	void Start () {
		ctrlPlayer = FactoryOfControllers.GetCtrlPlayer();
		
		asMusicVolcano = transform.FindChild_BB("Music Volcano").GetComponent_BB<AudioSource>();
		asSFXPlayerRunning = transform.FindChild_BB("SFX Player Running").GetComponent_BB<AudioSource>();
		
		ctrlPlayer.AddTransformToPlayerBase(asMusicVolcano.transform);
		ctrlPlayer.AddTransformToPlayerBase(asSFXPlayerRunning.transform);
	}
		
	public void SFX_Play_PlayerRunning(){		asSFXPlayerRunning.Play();}
	public void SFX_Pause_PlayerRunning(){		asSFXPlayerRunning.Pause();}
	public void SFX_Stop_PlayerRunning(){		asSFXPlayerRunning.Stop();}
	public bool SFX_IsPlaying_PlayerRunning(){	return asSFXPlayerRunning.isPlaying;}
	
	public void Music_Play_Volcano(){		asMusicVolcano.Play();}
	public void Music_Pause_Volcano(){		asMusicVolcano.Pause();}
	public void Music_Stop_Volcano(){		asMusicVolcano.Stop();}
	public bool Music_IsPlaying_Volcano(){	return asMusicVolcano.isPlaying;}
}
