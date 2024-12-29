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
    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        changeHealthText();
    }
    void changeHealthText()
    {
        healthText.SetText("Health: " + Mathf.RoundToInt(health) + "/100");
    }
    public static void removeHealth()
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
}
