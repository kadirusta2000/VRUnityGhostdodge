using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Material dodgeMaterial;
    [SerializeField] Material collectMaterial;
    private GameObject playerCamera;
    private float lifespan = 10f;
    private string type;
    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = GameObject.FindWithTag("MainCamera");
        int projectileType = Random.Range(0, 2);

        if (projectileType == 0)
        {
            GetComponent<Renderer>().material = dodgeMaterial;
            type = "dodge";
        }
        else
        {
            GetComponent<Renderer>().material = collectMaterial;
            type = "collect";
        }
        Vector3 playerPos = playerCamera.transform.position;
        transform.LookAt(playerPos);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        lifespan -= Time.deltaTime;
        if (lifespan <= 0.0f)
        {
            if (type == "collect")
            {
                HealthManager.takeDamageToHealth();
            }
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (type == "dodge")
            {
                HealthManager.takeDamageToHealth();
            }
                Destroy(this.gameObject);
        }

    }
}
