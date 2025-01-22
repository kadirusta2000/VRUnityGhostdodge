using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    private float minDistance = 1f;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, playerTransform.transform.position);

        if (distance > minDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerTransform.transform.position, minDistance);
        }
    }
}
