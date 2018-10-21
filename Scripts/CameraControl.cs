using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	private GameObject player = null;
	private Vector3 offset = Vector3.zero;
	/*
	private Vector3 prevPlayer;
	private Vector3 posVector;
	public float scale = 3.0f;
	public float cameraspeed = 1.0f;
	*/

	// Use this for initialization
	void Start () {
		//カメラを追従させるターゲットを探す
		player = GameObject.Find ("Player");
		//prevPlayer = new Vector3 (0, 0, -1);
		offset = transform.position - player.transform.position;
	}

	void LateUpdate () {
		//カメラの位置を決める
		Vector3 newPosition = transform.position;
		newPosition.x = player.transform.position.x + offset.x;
		newPosition.y = player.transform.position.y + offset.y;
		newPosition.z = player.transform.position.z + offset.z;
		transform.position = newPosition;
	}

	
	// Update is called once per frame
	void Update () {
		/*
		Vector3 currentPlayer = player.transform.position;
		Vector3 backVector = (prevPlayer - currentPlayer).normalized;
		posVector = (backVector == Vector3.zero) ? posVector : backVector;
		Vector3 targetPos = currentPlayer + scale * posVector;
		targetPos.y += 0.5f;
		this.transform.position = 
			Vector3.Lerp (this.transform.position, targetPos, cameraspeed * Time.deltaTime);
		this.transform.LookAt (player.transform.position);
		prevPlayer = player.transform.position;
		*/
	}
}
