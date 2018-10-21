using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveToMain : MonoBehaviour {
	private AudioSource tse;

	// Use this for initialization
	void Start () {
		tse = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Playボタンがクリックされた時の処理
	public void Menu()
	{
		tse.Play ();
		SceneManager.LoadScene ("MainLevel");
	}
}
