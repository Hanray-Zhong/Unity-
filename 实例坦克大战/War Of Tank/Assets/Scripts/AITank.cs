using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AITank : Unit {

    public GameObject player;
    public float speed;
    public float rotateSpeed;
    public float attackRange;

    private float shootCoolDown = 0;
    private TankWeapon tw;
    private NavMeshAgent nma;

    private void Start()
    {
        tw = GetComponent<TankWeapon>();
        nma = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(player.transform.position, transform.position);

        /*
        if (distance > attackRange)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        */

        nma.SetDestination(player.transform.position);

        if (distance <= attackRange)
            nma.ResetPath();

        Vector3 dir = player.transform.position - transform.position;

        shootCoolDown++;
        if (distance <= attackRange && shootCoolDown >= 25)
        {
            Quaternion wantedRotation = Quaternion.LookRotation(dir);
            transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, rotateSpeed * Time.deltaTime);
            tw.Shoot();
            shootCoolDown = 0;
        }

        
    }

}
