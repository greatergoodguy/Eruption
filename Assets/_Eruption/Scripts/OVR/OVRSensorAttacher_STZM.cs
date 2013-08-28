using UnityEngine;
using System.Collections;

public class OVRSensorAttacher_STZM : MonoBehaviour {
	
	void Start () {
		OVRMessenger.AddListener<OVRMainMenu.Device, bool>("Sensor_Attached", DummyMsgCallback);
	}
	
	void DummyMsgCallback(OVRMainMenu.Device dummyDevice, bool dummyBool){}
}
