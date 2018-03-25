using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MapEditor : MonoBehaviour {
	public Transform WallPrefab;
	public Transform PlayerPrefab;
	public int Seed=2;
	public string [,] mape = new string[39, 20]; 
	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < 38; i++) {
			for (int n = 0; n < 10; n++) {
				Transform Wall = Instantiate (WallPrefab );
				float x = 0.5f * i - 9f;
				float y = +n * 0.5f + 0.25f;
				Wall.position = new Vector3 (x, y, 10);
				mape [i, n] = "2,"+x + "," + y + "," + "10;";
				Wall.GetComponent <Editor > ().i = i;
				Wall.GetComponent <Editor > ().n = n;
			}
			for (int n = 0; n < 10; n++) {
				Transform Wall = Instantiate (WallPrefab);
				float x = 0.5f * i - 9f;
				float y = -n * 0.5f - 0.25f;
				Wall.position = new Vector3 (x, y, 10);
				mape [i, n + 10] = "2,"+x + "," + y + "," + "10;";
				Wall.GetComponent <Editor > ().i = i;
				Wall.GetComponent <Editor > ().n = n + 10;
			}
		}
		Transform Player = Instantiate (PlayerPrefab);
		Player.position = new Vector3 (-8f, 4.25f, 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnValueChanged(float Seede){
		Seed = (int)Seede;
		if (Seed != 0) {
			GameObject.Find ("Editor").GetComponent <Editor > ().OnMouseDown ();
		}
	}
	public void WriteOut(){
		FileStream MapTxt = new FileStream (Application.dataPath + "\\map.txt", FileMode.Create);
		Debug.Log (Application.dataPath + "\\map.txt");
		StreamWriter MapContent = new StreamWriter (MapTxt);
		string MapContentTxt = "";
		for (int i = 0; i < 38; i++) {
			for (int n = 0; n < 20; n++) {
				MapContentTxt = MapContentTxt + mape [i, n];
			}
		}
		MapContentTxt = MapContentTxt + mape [38, 0];
		MapContent.Write (MapContentTxt);
		MapContent.Flush();
		MapContent.Close();
	}
}
