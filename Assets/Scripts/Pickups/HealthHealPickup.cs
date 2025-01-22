using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHealPickup : MonoBehaviour, IPickupable
{
    public void OnPickup()
    {
        HealthManager.heal(20.0f);
        Destroy(this.gameObject);
    }
}
