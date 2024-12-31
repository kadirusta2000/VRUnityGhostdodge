using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour, ISpawnable
{   
    [SerializeField]
    private GameObject prefab;
    public void CreateInstance(Vector3 position)
    {
        Instantiate(prefab, position, Quaternion.identity);
    }
}
