using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface IPickupable : IEventSystemHandler
{
    void OnPickup();
}
