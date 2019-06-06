using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrashCartDestroyer : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		float TrashCart_difference = this.transform.position.z;
		//Debug.Log (this.transform.position.z);
		//ゴミ箱が視界から消えた時、ゴミ箱を破棄
		if(TrashCart_difference  <= -20.0f){
			Destroy(this.gameObject);
			//this.gameoverText.GetComponent<Text>().text = "GAME OVER";
		}
	}

}
