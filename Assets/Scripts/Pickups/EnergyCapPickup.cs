using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCapPickup : IPickupable
{
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, Space.Self);
    }
    override public void OnPickup()
    {
        pickedUp.Invoke("");
        EnergyManager.increaseEnergyCap();
        Destroy(this.gameObject);
    }
    void OnMouseDown()
    {
       OnPickup();
    }
}
