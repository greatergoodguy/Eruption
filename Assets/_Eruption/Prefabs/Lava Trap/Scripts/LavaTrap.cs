using UnityEngine;
using System.Collections;

public class LavaTrap : MonoBehaviour {
	
	public ModeLT mode = ModeLT.PlayerTrigger;
	
	public float riseSpeed = 10.0f;
	public float riseDuration = 1.5f;
	public float holdTopDuration = 1.5f;
	
	public GameObject lavaTrapObject;
	public AudioSource lavaTrapSound;
	
	private Vector3 riseVel = Vector3.zero;
	private Vector3 descendVel = Vector3.zero;
	
	private StateLT state = StateLT.HoldBottom;
	
	private float stateTimer = 0;
	
	public enum ModeLT{
		PlayerTrigger,
		Loop
	};
	
	private enum StateLT{
		Rise,
		Descend,
		HoldTop,
		HoldBottom
	};
	
	void Start() {
		riseVel = new Vector3(0, riseSpeed, 0);
		descendVel = new Vector3(0, -riseSpeed, 0);
		//lavaTrapObject = Instantiate(Resources.Load("Lava Trap Audio")) as GameObject;
		lavaTrapObject = GameObject.Find ("Lava Trap Audio");
		//transform.parent = lavaTrapObject.transform;
		lavaTrapSound = lavaTrapObject.GetComponent<AudioSource>();
	}
	
	void Update () {
		
		switch(mode){
		case ModeLT.PlayerTrigger:
			UpdatePlayerTriggerMode();
        	break;
		case ModeLT.Loop:
			UpdateLoopMode();
        	break;
    	default:
        	break;		
		}
		
		stateTimer += Time.deltaTime;
	}
	
	private void UpdatePlayerTriggerMode(){
		switch(state){
		case StateLT.Rise:
			transform.Translate(riseVel*Time.deltaTime);
			if(stateTimer > riseDuration)
				SwitchState(StateLT.HoldTop);
        	break;
        	
   		case StateLT.Descend:
			transform.Translate(descendVel*Time.deltaTime);
			float descendDuration = riseDuration;
			if(stateTimer > descendDuration)
				SwitchState(StateLT.HoldBottom);
        	break;
			
		case StateLT.HoldTop:
			if(stateTimer > holdTopDuration)
				SwitchState(StateLT.Descend);
        	break;
			
		case StateLT.HoldBottom:
        	break;
    	default:
        	break;	
		}
	}
	
	private void UpdateLoopMode(){
		
		switch(state){
		case StateLT.Rise:
			transform.Translate(riseVel*Time.deltaTime);
			if(stateTimer > riseDuration)
				SwitchState(StateLT.HoldTop);
        	break;
        	
   		case StateLT.Descend:
			transform.Translate(descendVel*Time.deltaTime);
			float descendDuration = riseDuration;
			if(stateTimer > descendDuration)
				SwitchState(StateLT.HoldBottom);
        	break;
			
		case StateLT.HoldTop:
			if(stateTimer > holdTopDuration)
				SwitchState(StateLT.Descend);
        	break;
			
		case StateLT.HoldBottom:
			float holdBottomDuration = holdTopDuration;
			if(stateTimer > holdBottomDuration)
				SwitchState(StateLT.Rise);
        	break;
    	default:
        	break;	
		}
	}
	
	private void SwitchState(StateLT newState){
		state = newState;
		stateTimer = 0;
		if (state.Equals(StateLT.HoldTop)) {
			lavaTrapSound.volume = 1.0f;
		} else {
			lavaTrapSound.volume = 0.0f;
		}
	}
}
