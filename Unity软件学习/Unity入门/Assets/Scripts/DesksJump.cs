using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesksJump : MonoBehaviour {

    private Transform transform;

	// Use this for initialization
	void Start () {
        transform = gameObject.GetComponent<Transform>();
         
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Jump();
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            Fall();
        }
        */
	}

    public void Jump()
    {
        transform.Translate(Vector3.up * 2, Space.World);
    }

    public void Fall()
    {
        transform.Translate(Vector3.up * -2, Space.World);
    }
}
