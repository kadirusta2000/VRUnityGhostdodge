using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCapPickup :  IPickupable
{
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, Space.Self);
    }
    override public void OnPickup()
    {
        pickedUp.Invoke("");
        HealthManager.increaseHealthCap();
        Destroy(this.gameObject);
    }
    void OnMouseDown()
    {
         OnPickup();
    }
}
