using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHealPickup : MonoBehaviour, IPickupable
{
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, Space.Self);
    }
    public void OnPickup()
    {
        HealthManager.heal(20.0f);
        Destroy(this.gameObject);
    }
    void OnMouseDown()
    {
        EnergyManager.increaseAcquisitionrate(0.1f);
        Destroy(this.gameObject);
    }
}
