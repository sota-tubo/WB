using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMoveObj : MonoBehaviour {
	GameObject VisObj;
	//OnCollisionが発動しているかいないか
	public static int bon;
	private GameObject BEXI;
	Vector3 bpos;
	string BS;
	public GameObject BMObj;
	public int bnum = 2;
	int i;

	// Use this for initialization
	void Start () {
		bon = 0;
		VisObj = GameObject.Find ("VisibleObj");
	}

	// Update is called once per frame
	void Update () {

	}

	/*
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player" && bon == 0)
		{
			bon = 1;
			Invoke ("BDestroy", 3.0f);
		}
	}

	void BDestroy()
	{
		Destroy (gameObject);
		bon = 0;
	}
	*/
}
