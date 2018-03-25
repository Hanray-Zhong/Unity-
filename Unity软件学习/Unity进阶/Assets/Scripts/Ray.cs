using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour {

    private UnityEngine.Ray _ray;
    private RaycastHit _raycastHit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(_ray, out _raycastHit))
            {
                GameObject.Destroy(_raycastHit.collider.gameObject);
            }
        }
	}
}
