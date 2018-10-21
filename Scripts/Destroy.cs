using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
	private GameObject refObj;

	// Use this for initialization
	void Start () {
		refObj = GameObject.Find ("VisibleObj");
	}
	
	// Update is called once per frame
	void Update () {
		if (Vis_Obj.wex == 0) {
			Destroy (gameObject);
		}
	}
}
