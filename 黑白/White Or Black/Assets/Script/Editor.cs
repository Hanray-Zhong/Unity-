using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Editor : MonoBehaviour {
	public int i;
	public int n;
	public Material White;
	public Material Black;
	public Material LoseBlack;
	public Material LoseWhite;
	public Material EndBlack;
	public Material EndWhite;
	public Material GBlack;
	public Material GWhite;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnMouseDown (){
		if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 2) {
			GetComponent <MeshRenderer> ().material = White;
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "2," + transform.position.x + "," + transform.position.y + "," + "10;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 1) {
			GetComponent <MeshRenderer> ().material = Black;
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "1," + transform.position.x + "," + transform.position.y + "," + "5;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 3) {
			GetComponent <MeshRenderer> ().material = LoseWhite;
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "3," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 4) {
			GetComponent <MeshRenderer> ().material = LoseBlack;
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "4," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 5) {
			GetComponent <MeshRenderer> ().material = EndBlack;
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "5," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 6) {
			GetComponent <MeshRenderer> ().material = EndWhite;
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "6," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 7) {
			GetComponent <MeshRenderer> ().material = GBlack;
			transform.rotation = Quaternion.Euler (0, 0, 0);
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "7," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 8) {
			GetComponent <MeshRenderer> ().material = GWhite;
			transform.rotation = Quaternion.Euler (0, 0, 0);
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "8," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 9) {
			GetComponent <MeshRenderer> ().material = GBlack;
			transform.rotation = Quaternion.Euler (0, 0, 270);
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "9," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 10) {
			GetComponent <MeshRenderer> ().material = GWhite;
			transform.rotation = Quaternion.Euler (0, 0, 270);
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "10," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 11) {
			GetComponent <MeshRenderer> ().material = GBlack;
			transform.rotation = Quaternion.Euler (0, 0, 90);
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "11," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 12) {
			GetComponent <MeshRenderer> ().material = GWhite;
			transform.rotation = Quaternion.Euler (0, 0, 90);
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "12," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 13) {
			GetComponent <MeshRenderer> ().material = GBlack;
			transform.rotation = Quaternion.Euler (0, 0, 180);
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "13," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent<MapEditor> ().Seed == 14) {
			GetComponent <MeshRenderer> ().material = GWhite;
			transform.rotation = Quaternion.Euler (0, 0, 180);
			GameObject.Find ("Main Camera").GetComponent <MapEditor> ().mape [i, n] = "14," + transform.position.x + "," + transform.position.y + "," + "7;";
		} else if (GameObject.Find ("Main Camera").GetComponent <MapEditor> ().Seed == 0) {
			GameObject.Find ("Player(Clone)").transform.position = new Vector3 (transform.position.x, transform.position.y, 2f);
			GameObject.Find ("Main Camera").GetComponent <MapEditor > ().mape [38, 0] = "0," + transform.position.x + "," + transform.position.y + "," + "5;";
		}
	}
}
