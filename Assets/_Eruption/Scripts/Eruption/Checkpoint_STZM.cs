using UnityEngine;
using System.Collections;

public class Checkpoint_STZM : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		PlatformerPhysics_STZM physics = other.gameObject.GetComponent<PlatformerPhysics_STZM>();
		if (physics)
		{
			//set new respawn point
			physics.SetRespawnPoint(transform.position);
		}
	}
}