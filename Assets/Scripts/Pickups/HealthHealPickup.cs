using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHealPickup : IPickupable
{
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, Space.Self);
    }
    override public void OnPickup()
    {
        pickedUp.Invoke("");        
        HealthManager.heal(30.0f);
        Destroy(this.gameObject);
    }
    void OnMouseDown()
    {
       OnPickup();
    }
}
