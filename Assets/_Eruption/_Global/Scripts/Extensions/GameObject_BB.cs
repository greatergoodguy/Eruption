using UnityEngine;
using System.Collections;

public static class GameObject_BB {    
	public static T GetComponent_BB<T>(this GameObject gameObject) where T : Component{
		T result = gameObject.GetComponent<T>();
		Assert_BB.Assert(result);
		return result;
	}
	
	public static GameObject Find(string name) {
		GameObject result = GameObject.Find(name);
		Assert_BB.AssertNotNull(result);
		return result;
	}
}