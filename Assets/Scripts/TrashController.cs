using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour {
	
	private Rigidbody myRigidbody;
	private float forwardForce = 2.0f;

	// Use this for initialization
	void Start () {
		this.myRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.myRigidbody.velocity =new Vector3 (0,0,-(this.forwardForce));
	}
}
