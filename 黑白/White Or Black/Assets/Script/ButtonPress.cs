using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void CardSelect(){
		GameObject.Find ("Canvas/CardSelect").GetComponent <RectTransform > ().anchoredPosition3D = new Vector3 (0, 0, 0);
	}
	public void BackToMainMenu(){
		if (SceneManager.GetActiveScene ().name == "Black And White") {
			GameObject.Find ("Canvas/CardSelect").GetComponent <RectTransform > ().anchoredPosition3D = new Vector3 (10000, 0, 0);
		} else {
			SceneManager.LoadScene ("Black And White");
		}
	}
	public void Card1Start(){
		Card1.num = 1;
		SceneManager.LoadScene ("NO.1");
	}
	public void Card2Start(){
		Card1.num = 2;
		SceneManager.LoadScene ("NO.1");
	}
	public void Card3Start(){
		Card1.num = 3;
		SceneManager.LoadScene ("NO.1");
	}
	public void Card4Start(){
		Card1.num = 4;
		SceneManager.LoadScene ("NO.1");
	}
	public void NextCard(){
		Card1.num = Card1.num + 1;
		SceneManager.LoadScene ("NO.1");
	}
	public void Restart(){
		SceneManager.LoadScene ("NO.1");
	}
}
