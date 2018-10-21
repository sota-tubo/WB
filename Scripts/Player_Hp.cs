using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Hp : MonoBehaviour {
	public static int Hp;
	private AudioSource hse;

	// Use this for initialization
	void Start () {
		//残機数を設定
		Hp = 3;
		hse = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
		//落下したり死亡判定のあるギミックに触れた場合
		if (collision.gameObject.tag == "Damage") {
			//残機を1機減らす
			Hp--;
			hse.Play ();
			if (Hp <= 0) {
				SceneManager.LoadScene ("GameOver");
			}
		}
	}
}
