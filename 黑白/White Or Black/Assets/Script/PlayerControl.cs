using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	public Vector3 Move;
	Vector3 Up;
	public bool PlayerJump = false;
	public bool Change = true;
	public bool Color=false ;
	public int Turn = 0;
	float MaxSpeed=5f;
	public Material Black;
	public Material White;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate(){
		MoveControl ();
	}
	//jue se yun dong kong zhi
	void MoveControl(){
		MoveMent ();
		//pan duan shi fou tiao yue,ru guo shu ru "w" bin qie zai di shang ze ke yi tiao yue
		if (Input.GetKey (KeyCode.Space)==true  && PlayerJump ==false) {
			//gei jue se gang ti yi ge xiang shang de su du
			gameObject.GetComponent <Rigidbody > ().velocity = new Vector3 (gameObject.GetComponent <Rigidbody > ().velocity.x+Up .x,gameObject.GetComponent <Rigidbody > ().velocity.y+ Up.y, 0);
		}
		//pan duan jue se su du shi fou da dao zui da
			//gei jue se gang ti shi jia yi dong de li
			gameObject.GetComponent <Rigidbody > ().AddForce (Move);
		if (Input.GetKey (KeyCode.E )==true &&PlayerJump ==false&&Change ==true) {
			if (Color == false) {
				Color = true ;
				Turnnum (Turn);
				transform.position = new Vector3 (transform.position.x, transform.position.y, 10f);
				GetComponent <MeshRenderer > ().material = White;
			} else {
				Color = false ;
				Turnnum (Turn);
				transform.position = new Vector3 (transform.position.x, transform.position.y, 5f);
				GetComponent <MeshRenderer > ().material = Black;
			}
		}
	}
	void MoveMent(){
		if (Turn == 0) {
			if (gameObject.GetComponent <Rigidbody > ().velocity.x <= MaxSpeed && gameObject.GetComponent <Rigidbody > ().velocity.x >= -MaxSpeed) {
				Move.x = Input.GetAxisRaw ("Horizontal") * 10;
			} else {
				Move.x = 0f;
			}
			Move.y = 0;
			Up.y = 5f;
			Up.x = 0;
		} else if (Turn == 3) {
			if (gameObject.GetComponent <Rigidbody > ().velocity.x <= MaxSpeed  && gameObject.GetComponent <Rigidbody > ().velocity.x >= -MaxSpeed ) {
				Move.x = Input.GetAxisRaw ("Horizontal") * 10;
			}else {
				Move.x = 0f;
			}
			Move.y = 0;
			Up.y = -5f;
			Up.x = 0;
		} else if (Turn == 1) {
			if (gameObject.GetComponent <Rigidbody > ().velocity.y <= MaxSpeed  && gameObject.GetComponent <Rigidbody > ().velocity.y >= -MaxSpeed ) {
				Move.x = Input.GetAxisRaw ("Horizontal") * 10;
			}else {
				Move.x = 0f;
			}
			Move.x = 0;
			Up.x = 5f;
			Up.y = 0;
		}else if (Turn == 2) {
			if (gameObject.GetComponent <Rigidbody > ().velocity.y <= MaxSpeed  && gameObject.GetComponent <Rigidbody > ().velocity.y >= -MaxSpeed ) {
				Move.x = Input.GetAxisRaw ("Horizontal") * 10;
			}else {
				Move.x = 0f;
			}
			Move.x = 0;
			Up.x = -5f;
			Up.y = 0;
		}
	}
	void Turnnum(int turnnum){
		if (turnnum ==2) {
			transform.Find ("GroundSelect").position = new Vector3 (transform.position.x - 0.8f, transform.position.y, transform.position.z);
			transform.position = new Vector3 (transform.position.x+0.65f, transform.position.y, 10f);
			Physics.gravity = new Vector3 (-9.81f, 0, 0);
			Turn = 1;
		}else if (turnnum ==1) {
			transform.Find ("GroundSelect").position = new Vector3 (transform.position.x + 0.8f, transform.position.y, transform.position.z);
			transform.position = new Vector3 (transform.position.x-0.65f, transform.position.y, 10f);
			Physics.gravity = new Vector3 (9.81f, 0, 0);
			Turn = 2;
		}else if (turnnum==0) {
			transform.Find ("GroundSelect").position = new Vector3 (transform.position.x, transform.position.y + 0.8f, transform.position.z);
			transform.position = new Vector3 (transform.position.x, transform.position.y-0.65f, 10f);
			Physics.gravity = new Vector3 (0, 9.81f, 0);
			Turn = 3;
		}else if (turnnum ==3) {
			transform.Find ("GroundSelect").position = new Vector3 (transform.position.x , transform.position.y-0.8f, transform.position.z);
			transform.position = new Vector3 (transform.position.x, transform.position.y+0.65f, 10f);
			Physics.gravity = new Vector3 (0, -9.81f, 0);
			Turn = 0;
		}
	}
	//void OnTriggerEnter(Collider OtherCollider){
	//	Debug.Log (OtherCollider.gameObject.name);
	//	if (OtherCollider.gameObject.name =="BlackWall(Clone)" && Color == false) {
			
	//		Change = true;
	//	} else if (OtherCollider.gameObject.name=="WhiteWall(Clone)" && Color == true) {
	//		Change = true;
	//	} else {
	//		Change = false;
	//	}
	//}
}
