using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    private static float health;
    [SerializeField]
    private TextMeshProUGUI healthText;
    private static float healthCap;
    // Start is called before the first frame update
    void Start()
    {
        health = 100.0f;
        healthCap = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        changeHealthText();
    }
    void changeHealthText()
    {
        healthText.SetText("Health: " + Mathf.RoundToInt(health) + "/" + healthCap);
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
    }
}
