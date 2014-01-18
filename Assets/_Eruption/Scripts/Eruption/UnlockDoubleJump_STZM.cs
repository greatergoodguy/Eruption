using UnityEngine;
using System.Collections;

public class UnlockDoubleJump_STZM : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		PlatformerPhysics_BB physics = other.gameObject.GetComponent<PlatformerPhysics_BB>();
		if (physics)
		{
			//unlock double jump and destroy ourselves
			physics.canDoubleJump = true;
			Destroy(gameObject);
		}
	}
}