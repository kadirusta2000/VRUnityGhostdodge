using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] GameObject projectile;
    private float minDistance = 1f;
    private float distance;
    public float shootTimer = 2.0f;
    public float projectileSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
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

        if (distance > minDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, minDistance);
        }
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
