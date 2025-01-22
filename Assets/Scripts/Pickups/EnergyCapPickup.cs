using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCapPickup : MonoBehaviour, IPickupable
{
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, Space.Self);
    }
    public void OnPickup()
    {
        EnergyManager.increaseEnergyCap();
        Destroy(this.gameObject);
    }
    void OnMouseDown()
    {
        EnergyManager.increaseAcquisitionrate(0.1f);
        Destroy(this.gameObject);
    }
}
