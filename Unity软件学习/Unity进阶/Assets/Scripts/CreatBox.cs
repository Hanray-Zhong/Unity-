using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatBox : MonoBehaviour {

    public GameObject goPrefab;


	// Use this for initialization
	void Start () {
        InvokeRepeating("AddBox", 3, 2);

    }

    // Update is called once per frame
    void Update () {
		
	}

    void AddBox()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector3 position;
            position = new Vector3(Random.Range(-90, 90), 20, Random.Range(-90, 90));
            GameObject.Instantiate(goPrefab, position, Quaternion.identity);
        }
    }
}
