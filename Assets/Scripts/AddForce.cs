using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {
	//ゴミ箱が進む速度
	private float forwardForce = 5f;
	private Rigidbody TBrb;
	// Use this for initialization
	void Start () {
		this.TBrb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		this.TBrb.velocity = new Vector3(TBrb.velocity.x,TBrb.velocity.y,-(this.forwardForce));
	}
}
