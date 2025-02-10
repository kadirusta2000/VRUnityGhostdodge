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
    [SerializeField] Transform gunPosition;
    [SerializeField] Animator animator;
    [SerializeField] float shootTimer;
    private float distance;
    private float minDistance = 1.5f;
    private float maxDistance = 2f;
    AnimatorClipInfo[] clipInfo;
    string currentAnimation;
    bool alive = true;
    bool isMoving = false;
    float zValue = 0f;

    private void Start()
    {
        this.animator.SetBool("isNoticing", true);

    }
    private void FixedUpdate()
    {
        if (alive) { 
            Vector3 pos = transform.position;
            float newY = Mathf.Sin(Time.time * 0.6f) +0.5f;
            transform.RotateAround(playerTransform.position, Vector3.up, 15 * Time.deltaTime);

            Vector3 targetPosition = new Vector3(playerTransform.position.x, pos.y, playerTransform.position.z);
            transform.LookAt(targetPosition);

            if (distance > maxDistance)
                transform.position = Vector3.MoveTowards(pos, playerTransform.position, 0.05f);

            if (distance < minDistance)
            {
                Vector3 invertedPos = playerTransform.position + new Vector3(minDistance, 0f, minDistance);//Vector3.Scale(playerTransform.position,new Vector3(1f,0f, 1f));
                transform.position = Vector3.MoveTowards(pos,invertedPos, 0.05f);
            }

            //if (distance > minDistance)
            //{
            //transform.position = Vector3.MoveTowards(pos, playerTransform.position, 0.05f);
            //}
            /*
            else
            {
                transform.position = new Vector3(playerTransform.position.x + 1f, newY, 0.01f) * 0.2f;
            }
            /*

            if (transform.position.y != playerTransform.position.y -0.6f)
            {
                transform.position = new Vector3(playerTransform.position.x +1f,Mathf.Lerp(playerTransform.position.y-0.9f, playerTransform.position.y - 0.3f,0.01f),0);
            }
            */



        }
    }
    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0.0f)
            {
                shoot();
                shootTimer = 2.0f;
            }
            distance = Vector3.Distance(transform.position, playerTransform.position);

        }
    }
    void shoot()
    {
        this.animator.SetBool("isNoticing", false);
        this.animator.SetBool("isShooting", true);
        clipInfo = this.animator.GetCurrentAnimatorClipInfo(0);
        currentAnimation = clipInfo[0].clip.name;
        if (currentAnimation == "Armature|Shoot")
        {
            GameObject projectileClone = Instantiate(projectile, gunPosition.position, transform.rotation);
        }
        /*
        Vector3 direction = playerTransform.position - transform.position;
        print(direction);
        direction = direction.normalized * projectileSpeed * Time.fixedDeltaTime;
        projectileClone.velocity = direction; //transform.TransformDirection(Vector3.forward * 3);
        */
        //projectileClone.transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, 0.1f);
    }
    public void Death()
    {
        alive = false;
        this.animator.SetBool("isDead", true);
    }
}
