using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCapPickup : MonoBehaviour, IPickupable
{
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, Space.Self);
    }
    public void OnPickup()
    {
        HealthManager.increaseHealthCap();
        Destroy(this.gameObject);
    }
    void OnMouseDown()
    {
        HealthManager.increaseHealthCap();
        Destroy(this.gameObject);
    }
}
