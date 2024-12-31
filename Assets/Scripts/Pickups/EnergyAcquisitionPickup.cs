using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class EnergyAcquisitionPickup : MonoBehaviour, IPickupable
{
    public void OnPickup()
    {
        EnergyManager.increaseAcquisitionrate(0.1f);
        //EnergyManager.increaseEnergyCap();
        Destroy(this.gameObject);
    }
}
