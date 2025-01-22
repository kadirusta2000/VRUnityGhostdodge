using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class PickupSpawnerManager : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;

    private void Start()
    {
        StartCoroutine(SpawnItemsOnRepeat());
    }
    void Update()
    {
        //Invoke("SpawnPickupItem", 10);
    }
    void SpawnPickupItem()
    {
        Vector3 itemPos = new Vector3(0,0,0);
        itemPos = playerObject.transform.position;
        itemPos.x += Random.Range(-10.0f, 10.0f); itemPos.y = 0; itemPos.z += Random.Range(-10.0f, 10.0f);    
        DecidePickupToSpawn().SendMessage("CreateInstance",itemPos);
    }
    GameObject DecidePickupToSpawn()
    {
        int rng = Random.Range(1, 5);
        switch(rng)
        {
            case 1: return GameObject.Find("EnergyAcquisitionPickupSpawner"); //FindInList("EnergyAcquisitionPickupSpawner");
            case 2: return GameObject.Find("EnergyCapPickupSpawner");
            case 3: return GameObject.Find("HealtCapPickupSpawner");
            case 4: return GameObject.Find("HealthHealPickupSpawner");
            case 5: return GameObject.Find("HealthFullHealPickupSpawner");
            default: return GameObject.Find("EnergyAcquisitionPickupSpawner");
        }
    }
    IEnumerator SpawnItemsOnRepeat()
    {
        //GameObject[] pickups = GameObject.FindGameObjectsWithTag("Pickup");
        while(GameObject.FindGameObjectsWithTag("Pickup").Length < 3)
        {
            SpawnPickupItem();
            //pickups = GameObject.FindGameObjectsWithTag("Pickup");
            yield return new WaitForSeconds(20f);
        }
    }
}
