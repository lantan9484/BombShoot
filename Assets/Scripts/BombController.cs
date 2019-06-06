using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour {

	public GameObject TrashPrefab;
	private Rigidbody myRigidbody;
	//タッチした時のゴミの位置
	private Vector3 touchPosition;
	//ドラッグしている時のゴミの位置
	private Vector3 movePosition;
	//ごみを一個だけ投げるためのブール関数
	private bool p = true;
	//ごみ
	private GameObject Trash;
	//タッチした時のごみの初期位置（ワールド座標に変換後）
	private Vector3 trashPos;
	//ドラッグしている時のごみの位置（ワールド座標に変換後）
	private Vector3 movetrashPos;
	//矢印
	public GameObject Arrow2D;
	//矢印
	public GameObject Arrow;


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			//	foreach (Touch t in Input.touches) ・・・複数タッチに対応する場合
			Touch t = Input.GetTouch (0);

			if (t.phase == TouchPhase.Began && p == true) {
				p = false;
				touchPosition = Input.GetTouch (0).position;
				touchPosition.z = 5f;
				//スクリーン座標からワールド座標へ（z軸は上で指定）
				trashPos = Camera.main.ScreenToWorldPoint (touchPosition);
				Trash = Instantiate (TrashPrefab) as GameObject;
				Arrow = Instantiate (Arrow2D) as GameObject;
				this.myRigidbody = Trash.GetComponent<Rigidbody> ();
				//爆弾の初期姿勢をランダムに
				Trash.transform.rotation = Random.rotation;
				Trash.transform.position = new Vector3 (trashPos.x, trashPos.y, trashPos.z);
				myRigidbody.isKinematic = true;
			}
				if (t.phase == TouchPhase.Moved) {
					movePosition = Input.GetTouch (0).position;
				    movePosition.z = 5f;
					movetrashPos = Camera.main.ScreenToWorldPoint (movePosition);
					Trash.transform.position = new Vector3 (movetrashPos.x, movetrashPos.y, movetrashPos.z);
				////////
					Vector3 vec = new Vector3(trashPos.x-movetrashPos.x,trashPos.y-movetrashPos.y,trashPos.z-movetrashPos.z);
					//Vector3 vec = new Vector3(touchPosition.x-movePosition.x,touchPosition.y-movePosition.y,0);
					//Arrow.transform.rotation = Quaternion.FromToRotation(Vector3.up, vec);
				Arrow.transform.LookAt(Arrow.transform.position + vec.normalized);

				Arrow.transform.position = new Vector3 (Trash.transform.position.x, Trash.transform.position.y,Trash.transform.position.z);
					//Debug.Log ("座標" + movetrashPos.x);
			}
			if (t.phase == TouchPhase.Ended) {
				//ボールを発射するコード
				//Destroy(Arrow);
				myRigidbody.isKinematic = false;
				Vector3 shootVec = trashPos - movetrashPos;
				//ボールの発射する強さを変更してください...200-300
				Trash.GetComponent<Rigidbody> ().AddForce (shootVec * 300);
				Destroy (Arrow);
				p = true;
			}
		}
	}
}