using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {

    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = gameObject.GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            rigidbody.AddForce(Vector3.forward * 30, ForceMode.Force);
        if (Input.GetKey(KeyCode.A))
            rigidbody.AddForce(Vector3.left * 30, ForceMode.Force);
        if (Input.GetKey(KeyCode.S))
            rigidbody.AddForce(Vector3.back * 30, ForceMode.Force);
        if (Input.GetKey(KeyCode.D))
            rigidbody.AddForce(Vector3.right * 30, ForceMode.Force);
    }


}
