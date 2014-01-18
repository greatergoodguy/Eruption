using UnityEngine;
using System.Collections;

public class CtrlPlayer : Ctrl_Base {
	
	Transform tPlayerBase;
	
	PlatformerAnimation_BB platformAnimation;
	PlatformerController_BB platformerController;
	PlatformerPhysics_BB platformerPhysics;
	
	void Awake() {
		tPlayerBase = transform.FindChild_BB("Player Base");
		
		platformAnimation = tPlayerBase.GetComponent_BB<PlatformerAnimation_BB>();
		platformerController = tPlayerBase.GetComponent_BB<PlatformerController_BB>();
		platformerPhysics = tPlayerBase.GetComponent_BB<PlatformerPhysics_BB>();
	}
	
	public Transform GetTransformPlayerBase() {
		return tPlayerBase;	
	}
	
	public void AddTransformToPlayerBase(Transform otherTransform) {
		otherTransform.parent = tPlayerBase;
	}
	
	public void SetRespawnPoint(Vector3 spawnPoint) {
		platformerPhysics.SetRespawnPoint(spawnPoint);
	}
	
	public bool HasControl() {
		return platformerController.HasControl();
	}
	
	public void PlayerDeath() {
		StartCoroutine(PlayerDeathCoroutine());
	}
	
	IEnumerator PlayerDeathCoroutine() {
		platformAnimation.PlayerDied();
		platformerController.RemoveControl();

		yield return new WaitForSeconds(2.5f);

		platformerPhysics.Reset();
		platformAnimation.PlayerLives();
		platformerController.GiveControl();
	}
}
