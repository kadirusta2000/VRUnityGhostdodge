using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCapPickup : MonoBehaviour, IPickupable
{
    public void OnPickup()
    {
        HealthManager.increaseHealthCap();
        Destroy(this.gameObject);
    }
}
