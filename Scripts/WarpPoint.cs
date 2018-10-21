using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.tag == "Player") {
			c.gameObject.transform.position = new Vector3(0f, 4.5f, -31.0f);
		}
	}
}
