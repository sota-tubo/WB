﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Quitボタンを押されたらゲーム終了
	public void Quit() {
		Application.Quit ();
	}
}
