using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveToTitle : MonoBehaviour {
	private AudioSource SE;

	// Use this for initialization
	void Start () {
		SE = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//ボタンがクリックされた時の処理
	public void Menu()
	{
		SE.Play ();
		SceneManager.LoadScene ("Title");
	}
}
