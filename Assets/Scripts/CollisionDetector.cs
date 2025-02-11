using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CollisionDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("EnemyProjectile"))
        {
            HealthManager.takeDamageToHealth();
            
        }
        else if(other.CompareTag("Pickup"))
        {
            other.gameObject.SendMessage("OnPickup"); //Legacy
            //ExecuteEvents.Execute<IPickupable>(other.gameObject, null, (x, y) => x.OnPickup());
        }
    }
}
