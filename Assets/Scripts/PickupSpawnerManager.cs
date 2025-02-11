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

    }
    void SpawnPickupItem()
    {
        Vector3 itemPos = new Vector3(0,0,0);
        itemPos = playerObject.transform.position;
        itemPos.x += Random.Range(-5.0f, 5.0f); itemPos.y = 0; itemPos.z += Random.Range(-5.0f, 5.0f);    
        DecidePickupToSpawn().SendMessage("CreateInstance",itemPos);
    }
    GameObject DecidePickupToSpawn()
    {
        int rng = Random.Range(1, 5);
        switch(rng)
        {
            case 2: return GameObject.Find("HealtCapPickupSpawner");
            case 3: return GameObject.Find("HealthHealPickupSpawner");
            case 4: return GameObject.Find("HealthFullHealPickupSpawner");
            default: return GameObject.Find("EnergyAcquisitionPickupSpawner");
        }
    }
    IEnumerator SpawnItemsOnRepeat()
    {
        while(GameObject.FindGameObjectsWithTag("Pickup").Length < 3)
        {
            SpawnPickupItem();
            yield return new WaitForSeconds(10f);
        }
    }
}
