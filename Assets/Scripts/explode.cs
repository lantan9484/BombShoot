using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//オブジェクトのパーティクルシステムを取得
		ParticleSystem particleSystem = GetComponent<ParticleSystem> ();
		//再生
		particleSystem.Play ();
		//duration時間後、削除
		Destroy (this.gameObject, particleSystem.main.duration);
	}
	
	// Update is called once per frame
	void Update () {
		}
}
