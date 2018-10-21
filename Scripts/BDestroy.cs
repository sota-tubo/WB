using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BDestroy : MonoBehaviour {
	GameObject refObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vis_Obj.bex == 0) {
			Destroy (gameObject);
		}
	}
}
