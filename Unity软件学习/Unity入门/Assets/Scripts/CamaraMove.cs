using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMove : MonoBehaviour {

    private Transform transform;
	// Use this for initialization
	void Start () {
        transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward, Space.World);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back, Space.World);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left, Space.World);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right, Space.World);
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            transform.Rotate(Vector3.up, 180);
            transform.Rotate(Vector3.left, -45);
        }

    }
}
