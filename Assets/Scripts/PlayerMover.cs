using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {
	public float speed=0.5f;
	public int coin = 0;

	Rigidbody rb;
	private Vector3 startPos;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		startPos = transform.position;
	}

	// Update is called once per frame
	void FixedUpdate (){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (-moveHorizontal, 0, -moveVertical);

		rb.AddForce (movement * speed);
	}



}