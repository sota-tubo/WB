using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WMoveObj : MonoBehaviour {
	private GameObject VisObj;
	//OnCollisionが発動しているかいないか
	public static int won;
	private GameObject WEXI;
	Vector3 wpos;
	string WS;
	public GameObject WMObj;
	public int wnum = 2;
	public Material[] mate;

	// Use this for initialization
	void Start () {
		won = 0;
		VisObj = GameObject.Find ("VisibleObj");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/*
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player" && won == 0)
		{
			won = 1;
			Invoke ("WDestroy", 3.0f);
		}
	}

	void WDestroy()
	{
		Destroy (gameObject);
		won = 0;
	}

	void Change() {
		
	}
	*/
}
