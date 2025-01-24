using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public abstract class IPickupable : MonoBehaviour, IEventSystemHandler
{

    public UnityEvent<string> pickedUp = new UnityEvent<string>();

    protected string pickUpType;

    /*
    void Start(){
        pickedUp.AddListener(GameObject.FindGameObjectWithTag("Notifications").GetComponent<Notifications>().CreateNotification);
        print(pickedUp.GetPersistentEventCount());
    }
    */
    public abstract void OnPickup();
}
