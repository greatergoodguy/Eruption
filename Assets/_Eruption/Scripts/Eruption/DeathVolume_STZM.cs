using UnityEngine;
using System.Collections;

public class DeathVolume_STZM : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		PlatformerController_STZM controller = other.gameObject.GetComponent<PlatformerController_STZM>();
		if (controller && controller.HasControl())
		{
			//let player die
			StartCoroutine(PlayerDeath(other.gameObject));
		}
	}

	IEnumerator PlayerDeath(GameObject player)
	{
		player.GetComponent<PlatformerAnimation_STZM>().PlayerDied();
		
		player.GetComponent<PlatformerController_STZM>().RemoveControl();

		yield return new WaitForSeconds(2.5f);

		player.GetComponent<PlatformerPhysics_STZM>().Reset();
		player.GetComponent<PlatformerAnimation_STZM>().PlayerLives();
		player.GetComponent<PlatformerController_STZM>().GiveControl();
	}
}

