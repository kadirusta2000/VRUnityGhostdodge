using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyAcquisitionPickup : MonoBehaviour, IPickupable
{
    public void OnPickup()
    {
        EnergyManager.increaseAcquisitionrate(0.1f);
        Destroy(this.gameObject);
    }
}
