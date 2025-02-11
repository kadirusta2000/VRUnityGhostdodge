using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public abstract class IPickupable : MonoBehaviour, IEventSystemHandler
{

    public UnityEvent<string> pickedUp = new UnityEvent<string>();



    public abstract void OnPickup();
}
