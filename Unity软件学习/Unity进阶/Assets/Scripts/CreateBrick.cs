using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBrick : MonoBehaviour {

    private int length = 90;
    private int width = 50;
    public GameObject brick;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < length; i += 6)
        {
            for (int j = 2; j < width; j += 3)
            {
                GameObject.Instantiate(brick, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
