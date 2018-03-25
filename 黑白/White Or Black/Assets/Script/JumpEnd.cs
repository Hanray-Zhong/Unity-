using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpEnd : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		bool Ray;
		if (transform.parent.gameObject.GetComponent <PlayerControl > ().Color ) {
			Ray = Physics.Linecast (transform.position, transform.parent.position, 1 << LayerMask.NameToLayer ("White")|1<<LayerMask .NameToLayer ("Default"));
		} else {
			Ray = Physics.Linecast (transform.position, transform.parent.position, 1 << LayerMask.NameToLayer ("Black")|1<<LayerMask .NameToLayer ("Default"));
		}
		if (Ray) {
			transform.parent.gameObject.GetComponent <PlayerControl > ().PlayerJump = false;
		} else {
			transform.parent.gameObject.GetComponent <PlayerControl > ().PlayerJump = true;
		}


		bool Ray2;
		if (transform.parent.gameObject.GetComponent <PlayerControl > ().Color ) {
			Ray2 = Physics.Linecast (transform.position, transform.parent.position, 1 << LayerMask.NameToLayer ("White"));
		} else {
			Ray2 = Physics.Linecast (transform.position, transform.parent.position, 1 << LayerMask.NameToLayer ("Black"));
		}
		if (Ray2) {
			transform.parent.gameObject.GetComponent <PlayerControl > ().Change  = true;
		} else {
			transform.parent.gameObject.GetComponent <PlayerControl > ().Change  = false;
		}
	}

}
