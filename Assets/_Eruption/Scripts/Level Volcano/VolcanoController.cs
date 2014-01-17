using UnityEngine;
using System.Collections;

public class VolcanoController : MonoBehaviour {

	private Vector3 launchForce = new Vector3(0, 0, 0);
	
	void Start () {
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Q)){
			launchBall();
		}
	}

	public void launchBall() {
		GameObject lavaBallGO = Instantiate(Resources.Load("LavaBall")) as GameObject;
		lavaBallGO.transform.parent = transform;
		lavaBallGO.transform.localPosition = new Vector3(0, 20, -2);	
		lavaBallGO.transform.rigidbody.AddForce(launchForce);
	}
}
