using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExplore : MonoBehaviour {

    public float damage;
    public GameObject ExplosionEffect;
    public float ExplosionRadius;
    public float ExplosionForce;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter()
    {
        GameObject newExplosionEffect = Instantiate(ExplosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(newExplosionEffect, 1);
        //audioSource.Play();

        Collider[] cols = Physics.OverlapSphere(transform.position, ExplosionRadius);
        if (cols.Length != 0)
        {
            foreach (var item in cols)
            {
                Rigidbody r = item.GetComponent<Rigidbody>();
                if (r != null)
                    r.AddExplosionForce(ExplosionForce, transform.position, ExplosionRadius);
                Unit u = item.GetComponent<Unit>();
                if (u != null)
                    u.ApplyDamage(damage);
            }
        }
    }

}
