using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAuto : MonoBehaviour {

    private DoorOpen doorOpen;

	// Use this for initialization
	void Start () {
        doorOpen = GameObject.Find("DoorFather").GetComponent<DoorOpen>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "Student")
            doorOpen.Open();
    }

    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.name == "Student")
            doorOpen.Close();
    }
}
