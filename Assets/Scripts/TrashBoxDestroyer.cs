using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrashBoxDestroyer : MonoBehaviour {

	//ゲームオーバーテキスと
	//private GameObject gameoverText;
	public bool gameover;

	// Use this for initialization
	void Start () {
		gameover = true;
		//this.gameoverText = GameObject.Find ("GameResultText");
	}
	
	// Update is called once per frame
	void Update () {
		float TrashBox_difference = this.transform.position.z;
		//Debug.Log (this.transform.position.z);
			//ゴミ箱が視界から消えた時、ゴミ箱を破棄
		if(TrashBox_difference  <= -20.0f && gameover == true){
				Destroy(this.gameObject);
			 //this.gameoverText.GetComponent<Text>().text = "GAME OVER";
				gameover = false;
			//ハイスコアをセーブ
			FindObjectOfType<Score> ().Save();
			//リザルト画面に移行
			//Debug.Log("SCORE:" + Score.highScore);
			SceneManager.LoadScene ("Result");
			}
	}
		
}
