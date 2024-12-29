using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("EnemyProjectile"))
        {
            HealthManager.removeHealth();
            Debug.Log("lol");
        }
    }
}
