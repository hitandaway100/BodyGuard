using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rigid2D;
	float walkForce = 100.0f;
	// Use this for initialization
	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			this.rigid2D.AddForce(transform.right * -1 * this.walkForce);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			this.rigid2D.AddForce(transform.right * this.walkForce);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			this.rigid2D.AddForce(transform.up * this.walkForce);
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			this.rigid2D.AddForce(transform.up * -1 * this.walkForce);
		}

	}
}
