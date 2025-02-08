using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Button flashlight;
    [SerializeField] GameObject flashlightObject;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.onClick.AddListener(FlashlightClicked);
    }

    void FlashlightClicked()
    {
        gameObject.SendMessage("FlashlightPressed", 5.0);
        flashlightObject.SetActive(false);
    }
}
