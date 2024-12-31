using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public interface ISpawnable : IEventSystemHandler
{
    void CreateInstance(Vector3 position);
}
