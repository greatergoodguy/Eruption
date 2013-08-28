using UnityEngine;
using System.Collections;

public static class SFXUtils {
	
	private static SFXController sfxController;
	
	static SFXUtils(){
		sfxController = GameObject.Find("SFX").GetComponent<SFXController>();	
	}
	
	
	public static void PlayBackgroundRumble(){	sfxController.PlayBackgroundRumble();}
	public static void PlayDeath(){				sfxController.PlayDeath();}
	public static void PlayGeyserErupt(){		sfxController.PlayGeyserErupt();}
	public static void PlayLakeWaves(){			sfxController.PlayLakeWaves();}
	public static void PlayLava(){				sfxController.PlayLava();}
	public static void PlayRockSmash(){			sfxController.PlayRockSmash();}
	public static void PlayRunning(){			sfxController.PlayRunning();}
	public static void PlayRunningFaster(){		sfxController.PlayRunningFaster();}
	public static void PlayVolcanoEruption(){	sfxController.PlayVolcanoEruption();}
	public static void PlayWaterSplash(){		sfxController.PlayWaterSplash();}
	
}
