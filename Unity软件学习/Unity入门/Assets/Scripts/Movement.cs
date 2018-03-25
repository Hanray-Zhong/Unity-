using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Transform transform;//定义字段


	// Use this for initialization
	void Start () {
        //首先让游戏物体获得组件
        transform = gameObject.GetComponent<Transform>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W) == true)
            transform.Translate(Vector3.forward * 0.5f, Space.Self);
        if (Input.GetKey(KeyCode.A) == true)
            transform.Translate(Vector3.left * 0.5f, Space.Self);
        if (Input.GetKey(KeyCode.D) == true)
            transform.Translate(Vector3.right * 0.5f, Space.Self);
        if (Input.GetKey(KeyCode.S) == true)
            transform.Translate(Vector3.back * 0.5f, Space.Self);
    }
}
