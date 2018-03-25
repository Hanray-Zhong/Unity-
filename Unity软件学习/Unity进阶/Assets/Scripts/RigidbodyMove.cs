using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMove : MonoBehaviour {

    private Transform _transform;
    private Rigidbody _rigidbody;

	// Use this for initialization
	void Start () {
        _transform = gameObject.GetComponent<Transform>();
        _rigidbody = gameObject.GetComponent<Rigidbody>();

		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            _rigidbody.MovePosition(transform.position + Vector3.forward);
        if (Input.GetKey(KeyCode.A))
            _rigidbody.MovePosition(transform.position + Vector3.left);
        if (Input.GetKey(KeyCode.S))
            _rigidbody.MovePosition(transform.position + Vector3.back);
        if (Input.GetKey(KeyCode.D))
            _rigidbody.MovePosition(transform.position + Vector3.right);



    }

    
}
