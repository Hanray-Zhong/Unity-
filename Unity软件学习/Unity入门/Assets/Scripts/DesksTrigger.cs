using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesksTrigger : MonoBehaviour {

    private DesksJump desksJump;

	// Use this for initialization
	void Start () {
        desksJump = GameObject.Find("Desks").GetComponent<DesksJump>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Student")
            desksJump.Jump();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Student")
            desksJump.Fall();
    }
}
