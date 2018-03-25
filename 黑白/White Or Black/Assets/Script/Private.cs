using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Private : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (File.Exists (Application.dataPath + "\\map.txt")) {

		} else {

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
