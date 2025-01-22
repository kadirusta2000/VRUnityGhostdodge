using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    private static float health;
    [SerializeField]
    private GameObject Healthbar;
    private static float healthCap;
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        healthCap = 100.0f;
        slider = Healthbar.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health/healthCap;
    }

    public static void takeDamageToHealth()
    {
        if(health - 30f > 0)
        {
            health -= 30f;
        }
        else
        {
            health = 0;
        }
        
    }
    public static void increaseHealthCap()
    {
        healthCap += 10.0f;
    }
    public static void healToHealthCap()
    {
        health = healthCap;
    }
    public static void heal(float healthAcquisition)
    {
        health += healthAcquisition;

        health = Mathf.Clamp(health, health, healthCap);
    }


}
