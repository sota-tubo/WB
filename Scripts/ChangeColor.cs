using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
	public Material[] mate;
	private int i, clr;
	public AudioClip WexSE;
	// Use this for initialization
	void Start () {
		i = 0;
		clr = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision c)
	{
		WMoveObj.won = 0;
		if (c.gameObject.tag == "Player" && WMoveObj.won == 0) {
			WMoveObj.won = 1;
			clr = 0;
			Invoke ("Change", 1.0f);
		}
	}

	void Change()
	{
		i++;
		if (i == 3) {
			i = 0;
		}
		clr++;
		this.GetComponent<Renderer> ().material = mate [i];
		if (clr == 1) {
			Invoke ("Change", 1.0f);
		} else if (clr == 2) {
			Invoke ("WDestroy", 1.0f);
		}
	}

	void WDestroy () {
		AudioSource.PlayClipAtPoint (WexSE, transform.position);
		Destroy (gameObject);
		WMoveObj.won = 0;
	}
}
