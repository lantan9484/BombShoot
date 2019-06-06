using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrashBoxGenerator : MonoBehaviour {

	//TrashBoxPrefabを入れる
	public GameObject TrashBoxPrefab;
	public GameObject TrashBox;
	//ゴミ箱生成時間の間隔
	private float interval = 4f;
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
			//randomrangeは整数だと最小値は含むが最大値は含まない
			p = Random.Range (1,4);
			if (p <= 2) {
				TrashBox = Instantiate (TrashBoxPrefab) as GameObject;
				TrashBox.transform.position = new Vector3 (0f, 3.5f, 20f);
				//Debug.Log("生成");
				//TBrb = TrashBox.GetComponent<Rigidbody> ();
				//Debug.Log("Move");
				t = 0;
			}
			if (p == 3) {
					TrashBox = Instantiate (TrashBoxPrefab) as GameObject;
					TrashBox.transform.position = new Vector3 (0f, 10f, 10f);
					t = 0;
			}
		}
	}
}
