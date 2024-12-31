using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class PickupSpawnerManager : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;
    private List<GameObject> spawnerList = new List<GameObject>();

    private void Start()
    {
        this.gameObject.GetChildGameObjects(spawnerList);
        InvokeRepeating("SpawnPickupItem",10,10);
    }
    void Update()
    {
        //Invoke("SpawnPickupItem", 10);
    }
    void SpawnPickupItem()
    {
        Vector3 itemPos = new Vector3(0,0,0);
        itemPos = playerObject.transform.position;
        itemPos.x += Random.Range(-10.0f, 10.0f); itemPos.z += Random.Range(-10.0f, 10.0f);    
        DecidePickupToSpawn().SendMessage("CreateInstance",itemPos);
    }
    GameObject DecidePickupToSpawn()
    {
        int rng = Random.Range(1, 3);
        switch(rng)
        {
            case 1: return FindInList("EnergyAcquisitionPickupSpawner");
            case 2: return FindInList("EnergyCapPickupSpawner");
            default: return FindInList("EnergyAcquisitionPickupSpawner");
        }
    }
    GameObject FindInList(string name)
    {
        foreach (GameObject item in spawnerList)
        {
            if (item.name.Equals(name)) return item;
        }
        return null;
    }
}
