using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Button flashlight;
    [SerializeField] GameObject flashlightObject;
    [SerializeField] GameObject congratsObject;
    public static bool flashlightPressed = false;
    EnemyController enemy;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.onClick.AddListener(FlashlightClicked);
        enemy = FindObjectOfType<EnemyController>();

    }

    void FlashlightClicked()
    {
        //gameObject.SendMessage("FlashlightPressed", 5.0);
        
        enemy.Death();
        flashlightObject.SetActive(false);
        Debug.Log(flashlightObject);
        congratsObject.SetActive(true);
    }
}
