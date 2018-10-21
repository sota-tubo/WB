using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Player : MonoBehaviour {
	//private CharacterController characon;
	[SerializeField] private float velocity = 2f;
	private Rigidbody rb;
	private float animSpeed;
	private Animator animator;

	// Use this for initialization
	void Start () {
		//characon = GetComponent<CharacterController> ();
		rb = GetComponent<Rigidbody> ();
		animSpeed = 1.5f;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		/*
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0, velocity * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, 0, -velocity * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-velocity * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (velocity * Time.deltaTime, 0, 0);
		}
		//if (characon.isGrounded) {
			//jump = Vector3.zero;
			if (Input.GetKeyDown (KeyCode.Space)) {
				//jump.y += jvelo;
				rb.AddForce(Vector3.up * jvelo, ForceMode.VelocityChange);
			}
		//}
		//jump.y += Physics.gravity.y * Time.deltaTime;
		//characon.Move (jump * Time.deltaTime);
		*/

        //移動処理
		float mx = Input.GetAxis("Horizontal");
		float mz = Input.GetAxis("Vertical");
		animator.SetFloat("Speed", mz);
		animator.SetFloat("Direction", mx);
		animator.speed = animSpeed;
        
		rb.AddForce(new Vector3(mx * velocity, 0f, mz * velocity));
	}
}
