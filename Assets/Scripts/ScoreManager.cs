using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private GameObject scoreText;
	//private int score;
	//スコア加算は一回だけ（多段を防ぐ）
	//private bool p;
	// Use this for initialization
	void Start () {
		//score = 0;
		//p = true;
		//this.scoreText = GameObject.Find("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Bomb") {
			FindObjectOfType<Score> ().AddPoint (100);
			//p = false;
			//this.score += 10;
			//this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";
			//Debug.Log ("score:" + this.score);
			Destroy (this.gameObject);
			//Debug.Log ("加点");
		}
	}
}
