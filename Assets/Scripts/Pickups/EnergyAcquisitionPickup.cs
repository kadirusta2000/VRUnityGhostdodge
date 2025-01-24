using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.Events;


public class EnergyAcquisitionPickup :  IPickupable
{
    

    void Update()
    {
        gameObject.transform.Rotate(Vector3.up,Space.Self);
        
    }
    override public void OnPickup()
    {
        EnergyManager.increaseAcquisitionrate(0.1f);
        pickedUp.Invoke("");
        Destroy(this.gameObject);
    }
    void OnMouseDown()
    {
        OnPickup();
    }
}
