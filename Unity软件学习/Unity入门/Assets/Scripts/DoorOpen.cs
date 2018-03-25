using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    private Transform transform;

	// Use this for initialization
	void Start () {
        transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
            Open();
        if (Input.GetKeyUp(KeyCode.Space))
            Close();
        */
	}

    public void Open()
    {
        transform.Rotate(Vector3.up, -90);
    }

    public void Close()
    {
        transform.Rotate(Vector3.up, 90);
    }
}
