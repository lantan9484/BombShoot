using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//TrashBoxPrefabを入れる
	public GameObject ScrollScorePrefab;
	public GameObject ScrScore;
	public GameObject Canvas;

	// スコアを表示する
	public Text scoreText;
	// ハイスコアを表示する
	public Text highScoreText;

	// スコア
	public static int score;

	// ハイスコア
	public static int highScore;

	// PlayerPrefsで保存するためのキー
	private string highScoreKey = "highScore";

	void Start ()
	{
		//初期化
		Initialize ();
	}

	void Update ()
	{
		// スコアがハイスコアより大きければ
		if (highScore < score) {
			highScore = score;
		}

		// スコア・ハイスコアを表示する
		scoreText.text = score.ToString ();
		highScoreText.text = highScore.ToString ();


	}

	// ゲーム開始前の状態に戻す
	private void Initialize ()
	{
		// スコアを0に戻す
		score = 0;

		// ハイスコアを取得する。保存されてなければ0を取得する。
		highScore = PlayerPrefs.GetInt (highScoreKey, 0);
	}

	// ポイントの追加
	public void AddPoint (int point)
	{
		score = score + point;
		//100点ごとに点数を告知
		if (score % 1000 == 0) {
			Debug.Log("生成");
			ScrScore = Instantiate (ScrollScorePrefab) as GameObject;
			//uGUIを表示するにはCanvas上に配置しないと表示されないらしい・・・
			ScrScore.transform.SetParent (Canvas.transform, false);
			//○○点オーバー！と表示
			ScrScore.GetComponent<Text>().text = score.ToString() + "OVER!";
			//1秒後に消える
			Destroy(ScrScore,0.5f);
		}
	}

	// ハイスコアの保存
	public void Save ()
	{
		// ハイスコアを保存する
		PlayerPrefs.SetInt (highScoreKey, highScore);
		PlayerPrefs.Save ();

		// ゲーム開始前の状態に戻す
		//Initialize ();

		//ハイスコアの取得
		highScore = PlayerPrefs.GetInt (highScoreKey, 0);
	}

}