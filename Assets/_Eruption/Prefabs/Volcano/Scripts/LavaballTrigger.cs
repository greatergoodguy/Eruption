using UnityEngine;
using System.Collections;

public class LavaballTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.Equals(GameObject.Find("Player"))) {
			GameObject.Find("Volcano").GetComponent<VolcanoController>().launchBall();
		} 
	}

}
