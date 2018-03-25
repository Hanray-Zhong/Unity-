using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
            
        }
    }
}
