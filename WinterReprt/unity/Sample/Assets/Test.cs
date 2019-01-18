using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    float rotSpeed = 0;//回転速度

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //マウスが押されたら回転速度を設定する
        if(Input.GetMouseButtonDown(0)){
            this.rotSpeed = 20;        
        }

        //回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);

        //ルーレットを減衰させる
        this.rotSpeed *= 0.96f;
	}
}
