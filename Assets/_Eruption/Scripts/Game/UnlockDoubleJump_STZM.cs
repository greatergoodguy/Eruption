using UnityEngine;
using System.Collections;

public class UnlockDoubleJump_STZM : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		PlatformerPhysics_STZM physics = other.gameObject.GetComponent<PlatformerPhysics_STZM>();
		if (physics)
		{
			//unlock double jump and destroy ourselves
			physics.canDoubleJump = true;
			Destroy(gameObject);
		}
	}
}