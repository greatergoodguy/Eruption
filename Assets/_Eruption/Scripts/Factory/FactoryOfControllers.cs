using UnityEngine;
using System.Collections;

public static class FactoryOfControllers {
        
	static CtrlMenuPause ctrlMenuPause;
	public static CtrlMenuPause GetCtrlMenuPause() {
		if(ctrlMenuPause == null) {
			ctrlMenuPause = GameObject_BB.Find("UI Menu Pause").GetComponent_BB<CtrlMenuPause>();}
                
		return ctrlMenuPause;
	}
}