using UnityEngine;
using System.Collections;

public class MouseSyncObject : MonoBehaviour {
	private Vector3 position; //MousePosition(Screen)
	private Vector3 screenToWorldPointPosition; //MousePosition(World)
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		position = Input.mousePosition;
        //Debug.Log(position); //マウス位置の確認
		position.z = 10f; //カメラからの距離に対応
		screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
		gameObject.transform.position = screenToWorldPointPosition;
	}
}
