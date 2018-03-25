using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : Unit {

    TankWeapon tw;

    public float moveSpeed;
    public float rotateSpeed;

    private float verticle;
    private float horizontal;
    private float shootCoolDown = 0;

    private void Start()
    {
        tw = gameObject.GetComponent<TankWeapon>();
    }

    void FixedUpdate () {
        horizontal = Input.GetAxis("Horizontal1");
        verticle = Input.GetAxis("Vertical1");
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * verticle, Space.Self);
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * horizontal, Space.Self);

        shootCoolDown++;

        if (Input.GetKeyDown(KeyCode.Space) && shootCoolDown >= 50)
        {
            shootCoolDown = 0;
            tw.Shoot();
        }
        /*
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime, Space.Self);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up * -rotateSpeed * Time.deltaTime, Space.Self);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.Self);
        */
    }
}
