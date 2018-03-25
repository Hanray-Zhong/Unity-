using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankWeapon : MonoBehaviour {

    public GameObject Shell;
    public Transform ShootPoint;
    public float ShootForce;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void Shoot()
    {
            GameObject newShell = Instantiate(Shell, ShootPoint.position, ShootPoint.rotation) as GameObject;
            Vector3 shootDirection = ShootPoint.up;
            newShell.GetComponent<Rigidbody>().AddForce(shootDirection * ShootForce, ForceMode.Impulse);
            audioSource.Play();
    }
}
