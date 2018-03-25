using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public enum Team
    {
        gold,
        blue
    }

    public float health = 100;
    public GameObject deadEffect;
    public GameObject deadBody;
    private bool isDead = false;
    private int a = 0;//只能变一次

    private void Update()
    {
        if (transform.rotation.x > 80 || transform.rotation.x < -80)
        {
            Destruct();
        }

        if (transform.rotation.y > 80 || transform.rotation.y < -80)
        {
            Debug.Log("111");
            Destruct();
        }

        if (transform.rotation.z > 80 || transform.rotation.z < -80)
        {
            Destruct();
        }
    }

    public void ApplyDamage(float damage)
    {
        if (damage < health)
        {
            health -= damage;
        }

        else
        {
            if (a == 0)
                isDead = true;
            if (isDead)
                Destruct();
        }
    }

    public void Destruct()
    {
        GameObject newEffect = Instantiate(deadEffect, transform.position, transform.rotation);
        Instantiate(deadBody, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(newEffect, 1);
        isDead = false;
        a ++;
    }

}
