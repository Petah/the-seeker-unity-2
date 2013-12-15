using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float moveSpeed = 5;

	public void Start() {
	
	}
	
	public void Update() {
		if (Input.GetAxis("Vertical") > 0.02f) {
			this.rigidbody.AddForce(transform.up * -moveSpeed);
		} else if (Input.GetAxis("Vertical") < -0.02f) {
			this.rigidbody.AddForce(transform.up * moveSpeed);
		}
		if (Input.GetAxis("Horizontal") > 0.02f) {
			this.rigidbody.AddForce(transform.right * moveSpeed);
		} else if (Input.GetAxis("Horizontal") < -0.02f) {
			this.rigidbody.AddForce(transform.right * -moveSpeed);
		}
	}

}
