using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vis_Obj : MonoBehaviour {
	public GameObject White;
	public GameObject Black;
	public GameObject MWhite;
	public GameObject MBlack;
	private GameObject WEXI;
	private GameObject BEXI;
	public AudioClip ChangeSE;
	private AudioSource BGM;
	//両方の色のオブジェクトが存在するかしないか(1=存在,0=存在しない)
	public static int wex = 0, bex = 0;
	//スポーン地点の個数
	public int wnum = 2, bnum = 2, mwnum = 2, mbnum = 2;
	Vector3 wpos, bpos;
	string WS, BS;
	int i;


	// Use this for initialization
	void Start () {
		BGM = GetComponent<AudioSource> ();
		BGM.Play ();
		for (i = 1; i <= wnum; i++) {
			//スポーン地点名
			WS = "WObjExists" + i;
			//スポーン地点判別
			WEXI = GameObject.Find (WS);
			//スポーン地点の位置
			wpos = WEXI.transform.localPosition;
			//スポーン
			Instantiate (White, wpos, Quaternion.identity);
		}
		for (i = 1; i <= mwnum; i++) {
			//スポーン地点名
			WS = "WMObjExists" + i;
			//スポーン地点判別
			WEXI = GameObject.Find (WS);
			//スポーン地点の位置
			wpos = WEXI.transform.localPosition;
			//スポーン
			Instantiate (MWhite, wpos, Quaternion.identity);
		}
		wex = 1;
		bex = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (wex == 1) {
				for (i = 1; i <= bnum; i++) {
					//スポーン地点名
					BS = "BObjExists" + i;
					//スポーン地点判別
					BEXI = GameObject.Find (BS);
					//スポーン地点の位置
					bpos = BEXI.transform.localPosition;
					//スポーン
					Instantiate (Black, bpos, Quaternion.identity);
				}
				for (i = 1; i <= mbnum; i++) {
					//スポーン地点名
					BS = "BMObjExists" + i;
					//スポーン地点判別
					BEXI = GameObject.Find (BS);
					//スポーン地点の位置
					bpos = BEXI.transform.localPosition;
					//スポーン
					Instantiate (MBlack, bpos, Quaternion.identity);
				}
				wex = 0;
				bex = 1;
				AudioSource.PlayClipAtPoint (ChangeSE, transform.position);
			} else {
				for (i = 1; i <= wnum; i++) {
					//スポーン地点名
					WS = "WObjExists" + i;
					//スポーン地点判別
					WEXI = GameObject.Find (WS);
					//スポーン地点の位置
					wpos = WEXI.transform.localPosition;
					//スポーン
					Instantiate (White, wpos, Quaternion.identity);
				}
				for (i = 1; i <= mwnum; i++) {
					//スポーン地点名
					WS = "WMObjExists" + i;
					//スポーン地点判別
					WEXI = GameObject.Find (WS);
					//スポーン地点の位置
					wpos = WEXI.transform.localPosition;
					//スポーン
					Instantiate (MWhite, wpos, Quaternion.identity);
				}
				wex = 1;
				bex = 0;
				AudioSource.PlayClipAtPoint (ChangeSE, transform.position);
			}
		}
	}
}
