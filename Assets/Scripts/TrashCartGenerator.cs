using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrashCartGenerator : MonoBehaviour {

	//TrashBoxPrefabを入れる
	public GameObject TrashCartPrefab;
	public GameObject TrashCart;
	//ゴミ箱生成時間の間隔
	private float interval = 2f;
	private float t = 0;

	//ランダム整数
	int p;


	//private Rigidbody TBrb;
	//private float forwardForce = 2.0f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		t += Time.deltaTime;
		if (t >= interval) {
			p = Random.Range (1, 10);
			if (p == 2) {
				TrashCart = Instantiate (TrashCartPrefab) as GameObject;
				//ｙをいじる必要性、カートが浮いてる？？
				TrashCart.transform.position = new Vector3 (4f, 0.758f, 20f);
				//Debug.Log("生成");
				//TBrb = TrashBox.GetComponent<Rigidbody> ();
				//Debug.Log("Move");
				t = 0;
			}
			else{
				t = 0;
			}
		}
	}
}
