using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class EnergyAcquisitionPickup : MonoBehaviour, IPickupable
{
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up,Space.Self);
    }
    public void OnPickup()
    {
        EnergyManager.increaseAcquisitionrate(0.1f);
        Destroy(this.gameObject);
    }
    void OnMouseDown()
    {
        EnergyManager.increaseAcquisitionrate(0.1f);
        Destroy(this.gameObject);
    }
}
