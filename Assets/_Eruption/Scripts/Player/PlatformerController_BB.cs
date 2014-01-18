using UnityEngine;
using System.Collections;

public class PlatformerController_BB : MonoBehaviour {
	PlatformerPhysics_BB mPlayer;
	bool mHasControl;
	
	bool isAnalogStickDownEnter = false;
	bool isAnalogStickDownStay = false;
	bool isAnalogStickDownExit = false;
	
	void Start () 
	{
		mHasControl = true;
		mPlayer = GetComponent<PlatformerPhysics_BB>();
		if (mPlayer == null)
			Debug.LogError("This object also needs a PlatformerPhysics component attached for the controller to function properly");
	}

	void Update () 
	{
		//here are the actions that are triggered by a press or a release
		if (mPlayer && mHasControl)
		{
			/*
			float verAxis =  Input.GetAxisRaw("Vertical");
			if(verAxis < -0.4f && !isAnalogStickDownStay && !isAnalogStickDownExit){
				isAnalogStickDownEnter = true;
				isAnalogStickDownStay = true;
				isAnalogStickDownExit = false;
			}
			if(verAxis > -0.4f && isAnalogStickDownStay){
				isAnalogStickDownEnter = false;
				isAnalogStickDownStay = false;
				isAnalogStickDownExit = true;
			}
			*/
			
			if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.JoystickButton14))
				mPlayer.StartSprint();

			if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift) || Input.GetKeyUp(KeyCode.JoystickButton14))
				mPlayer.StopSprint();

			if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || isAnalogStickDownEnter || Input.GetKeyDown(KeyCode.JoystickButton13)){
				isAnalogStickDownEnter = false;
				mPlayer.Crouch();
			}

			if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow) || isAnalogStickDownExit || Input.GetKeyUp(KeyCode.JoystickButton13)){
				isAnalogStickDownExit = false;
				mPlayer.UnCrouch();
			}
		}
	}
	
	void FixedUpdate(){
		//here are actions where the buttons can be held for a longer period
		if (mPlayer && mHasControl)
		{
			if (Input.GetButton("Jump") || Input.GetKey(KeyCode.JoystickButton16)){
				mPlayer.Jump();
			}
			
			float horAxis =  Input.GetAxisRaw("Horizontal");
			if(mPlayer.isAutoRun){
				horAxis += 0.5f;
			}
			mPlayer.Walk(horAxis);
		}
	}

	public void GiveControl() { mHasControl = true; }
	public void RemoveControl() { mHasControl = false; }
	public bool HasControl() { return mHasControl; }
}