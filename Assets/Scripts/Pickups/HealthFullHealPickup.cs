using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFullHealPickup : MonoBehaviour, IPickupable
{
    public void OnPickup()
    {
        HealthManager.healToHealthCap();
        Destroy(this.gameObject);
    }
}
