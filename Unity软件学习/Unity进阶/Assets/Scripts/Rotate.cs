using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    private Transform _transform;

	// Use this for initialization
	void Start () {
        _transform = gameObject.GetComponent<Transform>();
        _transform.Rotate(Vector3.forward, 90);
        _transform.Translate(Vector3.up * 5, Space.World);
        GameObject.Destroy(gameObject, 1);
	}
	
	// Update is called once per frame
	void Update () {
        _transform.Rotate(Vector3.left, 5);
        _transform.Translate(Vector3.up * 1, Space.World);
	}
}
