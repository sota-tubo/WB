using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BChangeColor : MonoBehaviour {
	public Material[] _material;
	private int i, clr;
	//AudioSource audioSource;
	public AudioClip exSE;
	// Use this for initialization
	void Start () {
		i = 0;
		clr = 0;
		//audioSource = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision c)
	{
		BMoveObj.bon = 0;
		if (c.gameObject.tag == "Player" && BMoveObj.bon == 0) {
			BMoveObj.bon = 1;
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
		this.GetComponent<Renderer> ().material = _material [i];
		if (clr == 1) {
			Invoke ("Change", 1.0f);
		} else if (clr == 2) {
			Invoke ("BDestroy", 1.0f);
		}
	}

	void BDestroy () {
		AudioSource.PlayClipAtPoint (exSE, transform.position);
		Destroy (gameObject);
		BMoveObj.bon = 0;
	}
}
