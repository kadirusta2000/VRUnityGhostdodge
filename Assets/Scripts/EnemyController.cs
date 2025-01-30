using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] GameObject projectile;
    [SerializeField] float minDistance = 1f;
    private float distance;
    public float shootTimer = 2.0f;


    private void FixedUpdate()
    {
        if (transform.position.y != playerTransform.position.y)
        {
            transform.position = new Vector3(playerTransform.position.x +1f,playerTransform.position.y,0);
        }

        if (distance > minDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, 0.05f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        shootTimer -= Time.deltaTime;
        if (shootTimer <= 0.0f)
        {
            shoot();
            shootTimer = 2.0f;
        }
        distance = Vector3.Distance(transform.position, playerTransform.transform.position);   
    }

    void shoot()
    {
        GameObject projectileClone = Instantiate(projectile, transform.position, transform.rotation);
        /*
        Vector3 direction = playerTransform.position - transform.position;
        print(direction);
        direction = direction.normalized * projectileSpeed * Time.fixedDeltaTime;
        projectileClone.velocity = direction; //transform.TransformDirection(Vector3.forward * 3);
        */
        //projectileClone.transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, 0.1f);
    }
}
