using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFullHealPickup : MonoBehaviour, IPickupable
{
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, Space.Self);
    }
    public void OnPickup()
    {
        HealthManager.healToHealthCap();
        Destroy(this.gameObject);
    }
    void OnMouseDown()
    {
        EnergyManager.increaseAcquisitionrate(0.1f);
        Destroy(this.gameObject);
    }
}
