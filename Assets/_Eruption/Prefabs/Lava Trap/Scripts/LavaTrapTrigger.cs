using UnityEngine;
using System.Collections;

public class LavaTrapTrigger : MonoBehaviour {
	
	void OnCollisionEnter(Collision collision) {
		print ("collision");
	}
	
	void OnTriggerEnter(Collider other) {
		print ("boom");
	}
}
