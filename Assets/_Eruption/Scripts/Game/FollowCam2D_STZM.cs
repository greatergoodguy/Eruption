using UnityEngine;
using System.Collections;

public class FollowCam2D_STZM: MonoBehaviour {
	public Transform target;

	private float distance = 15.0f;
	private float extraHeight = 5.0f;
	
	private Vector3 originPos;
	private Quaternion originRot;
	private float intensity;
	private float decay;
	private bool shaking;
	
	float origDist;
	
	bool isClose = false;
	
	void Start () 
	{
		origDist = distance;
		intensity = 0;
		shaking = false;
		
	}

	void FixedUpdate () 
	{
		if (target)
		{
			
			if (Input.GetKey(KeyCode.Period)) {
				cameraShake(0.3f, 0.002f);
			}
			
			if (Input.GetKey(KeyCode.LeftControl)) {
				distance = origDist * 5;
			} else {
				distance = origDist;
			}

			if(!isClose){
				Vector3 targetPos = target.position + Vector3.up * extraHeight;
				targetPos.z = targetPos.z - distance;
				transform.position -= (transform.position - targetPos) * 0.25f;
				originPos = transform.position;
				originRot = transform.rotation;
			}
			else{
				Vector3 targetPos = target.position + Vector3.up * 7.0f;
				targetPos.z = targetPos.z - 4.0f;
				transform.position -= (transform.position - targetPos) * 0.25f;
				originPos = transform.position;
				originRot = transform.rotation;
			}
		}
		
		if (shaking) {
			if (intensity > 0) {
				transform.position = originPos + Random.insideUnitSphere*intensity;
				transform.rotation = new Quaternion(
					originRot.x + Random.Range(-intensity, intensity)*.2f,
					originRot.y + Random.Range (-intensity, intensity)*.2f,
					originRot.z + Random.Range (-intensity, intensity)*.2f,
					originRot.w + Random.Range(-intensity, intensity)*.2f);
				intensity -= decay;
			} else {
				shaking = false;
				transform.position = originPos;
				transform.rotation = originRot;
			}
		}
	}

	public void SetTarget(Transform inTarget)
	{
		target = inTarget;
		isClose = false;
	}
	
	public void SetTarget(Transform inTarget, bool isClose)
	{
		target = inTarget;
		this.isClose = isClose;
	}
	
	public void cameraShake(float _intensity, float _decay) {
		
		intensity = _intensity;
		decay = _decay;
		shaking = true;
	}
	
}

