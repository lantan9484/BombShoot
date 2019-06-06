using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {


	int a;
	// スコアを表示する
	public Text result_scoreText;
	// ハイスコアを表示する
	public Text result_highScoreText;


	// Use this for initialization
	void Start () {
		result_scoreText.text = Score.score.ToString();
		result_highScoreText.text = Score.highScore.ToString();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
