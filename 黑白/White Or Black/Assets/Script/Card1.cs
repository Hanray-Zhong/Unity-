using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card1 : MonoBehaviour {
	public Transform BlackWall;
	public Transform WhiteWall;
	public Transform End;
	public Transform Losel;
	public Transform Losew;
	public Transform TurnDown;
	public Transform TurnLeft;
	public Transform TurnRight;
	public Transform TurnUp;
	public TextAsset Card1Componente;
	public Material EndBlack;
	public Material GBlack;
	public Transform PlayerPrefab;
	public static int num = 1;
	// Use this for initialization
	void Start () {
		Card1Componente = Resources.Load ("Card" + num) as TextAsset;
		string Card1Component = Card1Componente.text;
		string []dot=Card1Component.Split (new char[1] { ';' });
		string[,] dot3=new string[761,4] ;
		for (int i = 0; i < 761; i++) {
			string [] dot2 = dot[i].Split (new char[1] { ',' });
			for (int n = 0; n < 4; n++) {
				dot3 [i, n] = dot2 [n];
			}
		}
		for (int i = 0; i < 761; i++) {
			if (dot3 [i, 0] == "1") {
				Transform Item = Instantiate (BlackWall);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
			} else if (dot3 [i, 0] == "2") {
				Transform Item = Instantiate (WhiteWall);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
			}else if (dot3 [i, 0] == "3") {
				Transform Item = Instantiate (Losel);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
			}else if (dot3 [i, 0] == "4") {
				Transform Item = Instantiate (Losew);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
			}else if (dot3 [i, 0] == "5") {
				Transform Item = Instantiate (End);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
				Item.GetComponent <MeshRenderer > ().material = EndBlack;
			}else if (dot3 [i, 0] == "6") {
				Transform Item = Instantiate (End);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
			}else if (dot3 [i, 0] == "7") {
				Transform Item = Instantiate (TurnDown);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
				Item.GetComponent <MeshRenderer > ().material = GBlack;
			}else if (dot3 [i, 0] == "8") {
				Transform Item = Instantiate (TurnDown);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
			}else if (dot3 [i, 0] == "10") {
				Transform Item = Instantiate (TurnLeft);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
			}else if (dot3 [i, 0] == "9") {
				Transform Item = Instantiate (TurnLeft);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
				Item.GetComponent <MeshRenderer > ().material = GBlack;
			}else if (dot3 [i, 0] == "11") {
				Transform Item = Instantiate (TurnRight);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
				Item.GetComponent <MeshRenderer > ().material = GBlack;
			}else if (dot3 [i, 0] == "12") {
				Transform Item = Instantiate (TurnLeft);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
			}else if (dot3 [i, 0] == "13") {
				Transform Item = Instantiate (TurnUp);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
				Item.GetComponent <MeshRenderer > ().material = GBlack;
			}else if (dot3 [i, 0] == "14") {
				Transform Item = Instantiate (TurnUp);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
			} else if (dot3 [i, 0] == "0") {
				Transform Item = Instantiate (PlayerPrefab);
				Item.position = new Vector3 (float.Parse (dot3 [i, 1]), float.Parse (dot3 [i, 2]), float.Parse (dot3 [i, 3]));
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
