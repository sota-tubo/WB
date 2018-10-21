using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Escape : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R) && Player_Hp.Hp > 1) {
			Player_Hp.Hp--;
			transform.position = new Vector3 (0f, 4.5f, -31.0f);
		}
		
	}
}
