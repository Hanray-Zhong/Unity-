using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BoxDisappear : MonoBehaviour {

    public GameObject coin_prefab;
    private Text _text;

    // Use this for initialization
    void Start () {
        GameObject.Destroy(gameObject, Random.Range(5, 10));
        _text = GameObject.Find("Score").GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GameObject.Destroy(gameObject);
            GameObject.Instantiate(coin_prefab, gameObject.transform.position, Quaternion.identity);
            AddScore();
        }


    }

    void AddScore()
    {
        int i = int.Parse(_text.text);
        _text.text = (++i).ToString();
    }
}
