using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] Button flashlight;
    [SerializeField] GameObject flashlightObject;
    [SerializeField] Image flashlightEffect;

    [SerializeField] GameObject displayText;

    [SerializeField] GameObject Crosshair;

    [SerializeField] GameObject Notifications;

    [SerializeField] GameObject Overlay;

    [SerializeField] Slider Lifebar;

    [SerializeField] GameObject Crack;
    [SerializeField] GameObject Crack2;
    [SerializeField] GameObject Crack3;

    public static bool flashlightPressed = false;
    public static bool alive = true;

    public static TMP_Text displayTextContent; 
    EnemyController enemy;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.onClick.AddListener(FlashlightClicked);
        enemy = FindObjectOfType<EnemyController>();
        displayTextContent = displayText.GetComponent<TMP_Text>();
    }


    void Update(){
        if (flashlightEffect.color.a > 0f)
        {
            var tempColor = flashlightEffect.color;
            tempColor.a = Mathf.Lerp(flashlightEffect.color.a, 0, 0.01f);
            flashlightEffect.color = tempColor;
        }
        float life = Lifebar.value;

        switch(life){
            case float i when i > 0.5 && i < 0.7:
                Crack.SetActive(true);
                break;
            case float i when i > 0.2 && i < 0.5:
                Crack2.SetActive(true);
                break;
            case float i when i > 0 && i < 0.2:
                Crack3.SetActive(true);
                break;
            case float i when i <= 0:
                alive = false;
                deactiveUiElements();
                Overlay.SetActive(true);
                displayTextContent.text ="Your device broke!";
                displayText.SetActive(true);
                break;
        }
        

        if(Lifebar.value == 0){
            alive = false;
            deactiveUiElements();
            Overlay.SetActive(true);
            displayTextContent.text ="Your device broke!";
            displayText.SetActive(true);
        }
    }
    void FlashlightClicked()
    {
        if(alive){
            GetComponent<AudioSource>().Play();
            var tempColor = flashlightEffect.color;
            tempColor.a = 0.9f;
            flashlightEffect.color = tempColor;
            enemy.Death();

            deactiveUiElements();


            displayText.SetActive(true);
            Overlay.SetActive(true);
        }
    }

    void deactiveUiElements(){
        flashlightObject.SetActive(false);
        Crosshair.SetActive(false);
        Notifications.SetActive(false);
    }
}
