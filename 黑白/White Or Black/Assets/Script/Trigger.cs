using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider OtherCollider){
		if (OtherCollider.gameObject.name == "End(Clone)") {
			Destroy (transform.parent.gameObject);
			GameObject.Find ("Canvas/Win").GetComponent <RectTransform > ().anchoredPosition3D = new Vector3 (0, 0, 0);
		}else if(OtherCollider .gameObject .name =="Lose(L)(Clone)"||OtherCollider .gameObject .name =="Lose(W)(Clone)"){
			Destroy (transform.parent.gameObject);
			GameObject.Find ("Canvas/Lose").GetComponent <RectTransform > ().anchoredPosition3D = new Vector3 (0, 0, 0);
		} else if (OtherCollider.gameObject.name == "TurnLeft(Clone)") {
			transform.parent.Find ("GroundSelect").position = new Vector3 (transform.parent.position.x - 0.8f, transform.parent.position.y, transform.parent.position.z);
			Physics.gravity = new Vector3 (-9.81f, 0, 0);
			transform.parent.gameObject.GetComponent <PlayerControl > ().Turn = 1;
		}else if (OtherCollider.gameObject.name == "TurnRight(Clone)") {
			transform.parent.Find ("GroundSelect").position = new Vector3 (transform.parent.position.x + 0.8f, transform.parent.position.y, transform.parent.position.z);
			Physics.gravity = new Vector3 (9.81f, 0, 0);
			transform.parent.gameObject.GetComponent <PlayerControl > ().Turn = 2;
		}else if (OtherCollider.gameObject.name == "TurnUp(Clone)") {
			transform.parent.Find ("GroundSelect").position = new Vector3 (transform.parent.position.x , transform.parent.position.y+0.8f, transform.parent.position.z);
			Physics.gravity = new Vector3 (0, 9.81f, 0);
			transform.parent.gameObject.GetComponent <PlayerControl > ().Turn = 3;
		}else if (OtherCollider.gameObject.name == "TurnDown(Clone)") {
			transform.parent.Find ("GroundSelect").position = new Vector3 (transform.parent.position.x , transform.parent.position.y-0.8f, transform.parent.position.z);
			Physics.gravity = new Vector3 (0, -9.81f, 0);
			transform.parent.gameObject.GetComponent <PlayerControl > ().Turn = 0;
		}
	}
}
