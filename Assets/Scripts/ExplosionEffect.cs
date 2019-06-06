using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour {

	private bool p = true;
	public GameObject explode;

	// Use this for initialization
	void Start () {
	}

		
	// Update is called once per frame
	void Update () {
		//explode.GetComponent<ParticleSystem> ().Play ();
		//Destroy (other.gameObject);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "TrashBox" && p == true) {
			p = false;
			Instantiate (explode, this.transform.position, Quaternion.identity);
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == "TrashCart" && p == true) {
			p = false;
			Instantiate (explode, this.transform.position, Quaternion.identity);
			Destroy (this.gameObject);
		}
	}

}
