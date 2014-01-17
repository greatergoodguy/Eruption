using UnityEngine;
using System.Collections;

public static class Transform_BB {    
	public static Transform FindChild_BB(this Transform transform, string childName){
		Transform result = transform.FindChild(childName);
		Assert_BB.AssertNotNull(result);
        return result;
	}
	
	public static GameObject FindChildAsGameObject_BB(this Transform transform, string childName){
		Transform result = transform.FindChild(childName);
		Assert_BB.AssertNotNull(result);
        return result.gameObject;
	}
	
	public static T GetComponent_BB<T>(this Transform transform) where T : Component {
		T result = transform.GetComponent<T>();
		Assert_BB.AssertNotNull(result);
		return result;
	}
}