using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDemo : MonoBehaviour {

    private UnityEngine.Ray _ray;
    private RaycastHit _raycastHit;
    public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SendBullet();
	}

    void SendBullet()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(_ray, out _raycastHit))
            {

                //实例化子弹
                GameObject sended_bullet = GameObject.Instantiate(bullet, gameObject.transform.position, Quaternion.identity);

                //发射子弹
                Vector3 BulletWay = _raycastHit.point - gameObject.transform.position;
                sended_bullet.GetComponent<Rigidbody>().AddForce(BulletWay, ForceMode.Impulse);

                
            }
        }
    }
}
