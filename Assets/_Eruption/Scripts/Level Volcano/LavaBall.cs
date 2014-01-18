using UnityEngine;
using System.Collections;

public class LavaBall : MonoBehaviour {
	
	public GameObject target;
	
	public int midpointHeightOffset = 200;
	public int targetHeightOffset = 3;
	public int targetForwardOffset = 30;
	
	public float duration = 5;
	
	private float targetZPos = 0;
	private float targetZPosPadding = 1.0f;
	
	private bool isLocked = false;
	
	private Vector3 startVec = Vector3.zero;
	private Vector3 endVec = Vector3.zero;
	private Vector3 midpointVec = Vector3.zero;
	
	private GameObject audioListenerGO;
	
	private bool isFirstTimeCollision = true;
	
	bool hasCollided;
	float timer;
	const float LIFETIME = 10f; // lifetime in seconds
	bool isShrinking = false;
	
	void Start () {
		if(target == null){
			target = GameObject.Find("Player");
		}
		
		audioListenerGO = GameObject.Find("OVRCameraController_BB");
		
		Vector3 midpointHeightOffsetVec = new Vector3(0, midpointHeightOffset, 0);
		Vector3 targetHeightOffsetVec = new Vector3(0, targetHeightOffset, 0);
		Vector3 targetForwardOffsetVec = new Vector3(targetForwardOffset, 0, 0);
		
		startVec = transform.position;
		endVec = target.transform.position + targetHeightOffsetVec + targetForwardOffsetVec;
		midpointVec = (startVec + endVec) / 2 + midpointHeightOffsetVec;
		
		Vector3[] pathToPlayerPart1 = {
			getBezierPoint(0f), 
			getBezierPoint(0.1f), 
			getBezierPoint(0.2f), 
			getBezierPoint(0.3f), 
			getBezierPoint(0.4f),
			getBezierPoint(0.5f)};
		
		Vector3[] pathToPlayerPart2 = {
			getBezierPoint(0.5f),
			getBezierPoint(0.6f),
			getBezierPoint(0.7f),
			getBezierPoint(0.8f),
			getBezierPoint(0.9f), 
			getBezierPoint(1f)};
		
		iTween.MoveTo(gameObject, iTween.Hash("time", duration/2, "path", pathToPlayerPart1, "delay", 0, "easeType", "easeOutSine"));
		iTween.MoveTo(gameObject, iTween.Hash("time", duration/2, "path", pathToPlayerPart2, "delay", duration/2, "easeType", "easeInSine"));
		
	}
	void Update () {
		
		if (timer >= LIFETIME) {
			if (!isShrinking) {
				iTween.ScaleBy (gameObject, iTween.Hash ("x", 0f, "y", 0f, "z", 0f, "time", 3f, "easeType", "easeOutQuart", "onComplete", "destroy"));
				isShrinking = true;
			}
		} else if (!isFirstTimeCollision) {
			timer += Time.deltaTime;
		}
		
		if(!isLocked){
			if(transform.position.z > targetZPos - targetZPosPadding && 
				transform.position.z < targetZPos + targetZPosPadding){
				rigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
				isLocked = true;
			}
		}
	}
	
	private Vector3 getBezierPoint(float t){
		return (1 - t)*(1 - t)*startVec + 2*(1 - t)*t*midpointVec + t*t*endVec;
	}
	
	void OnCollisionEnter(Collision collision){
		
		if(isFirstTimeCollision){
			foreach (ContactPoint contact in collision.contacts) {
				if (contact.otherCollider.name.Equals("Terrain")) {
					Vector3 n = contact.normal;
					float angle = Vector3.Angle(n, transform.right);
					print ("Angle: " + angle);
					if (angle < 85 || angle > 95) {
						isLocked = true;
					}
					break;
				}
			}
			GameObject lavaBallRockSmashAudio = Instantiate(Resources.Load("LavaBallRockSmashAudio")) as GameObject;
			lavaBallRockSmashAudio.transform.parent = audioListenerGO.transform;
			lavaBallRockSmashAudio.transform.localPosition = new Vector3(0, 0, 0);			
			
			isFirstTimeCollision = false;
		}
	}
	
	private void destroy() {
		print ("destroying!");
		Destroy(gameObject);
	}
}
