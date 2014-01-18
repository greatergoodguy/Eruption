using UnityEngine;
using System.Collections;

public class LavaballEruptionTrigger : MonoBehaviour {
	
	private GameObject audioListenerGO;	
	
	void Start() {
		audioListenerGO = GameObject.Find("OVRCameraController_BB");
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.Equals(GameObject.Find("Player Base"))) {
			
			GameObject lavaBallEruptionAudio = Instantiate(Resources.Load("LavaBallEruptionAudio")) as GameObject;
			lavaBallEruptionAudio.transform.parent = audioListenerGO.transform;
			lavaBallEruptionAudio.transform.localPosition = new Vector3(0, 0, 0);	
		} 
	}

}
