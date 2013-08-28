using UnityEngine;
using System.Collections;

public class EndScreenTrigger : MonoBehaviour {
	
	public Texture endScreenTexture;
	
	private bool isGuiOn = false;
	
	private float resetTimer = 0f;
	
	void Start() {
	}
	
	void Update(){
		if(isGuiOn){
			resetTimer += Time.deltaTime;
			
			if(resetTimer > 8.0f)
				Application.LoadLevel(0);
		}
	}
	
	void OnGUI() {
		if(isGuiOn){
			GuiUtilsOR.DrawTextureHelper(70, 70, 500, 500, endScreenTexture);	
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.Equals(GameObject.Find("Player"))) {
			isGuiOn = true;			
		} 
	}
	
}
