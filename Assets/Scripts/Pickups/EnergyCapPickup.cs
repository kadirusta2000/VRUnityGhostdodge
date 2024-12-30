using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCapPickup : MonoBehaviour, IPickupable
{
    public void OnPickup()
    {
        EnergyManager.increaseEnergyCap();
        Destroy(this.gameObject);
    }
}
