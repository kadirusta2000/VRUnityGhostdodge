using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class EnergyManager : MonoBehaviour
{
    private float energy;
    [SerializeField]
    private TextMeshProUGUI energyText;
    // Start is called before the first frame update
    void Start()
    {
        energy = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        increaseEnergy();
    }
    void increaseEnergy()
    {
        if (energy > 100)
        {
            energy = 100.0f;
        }
        else
        {
            energy += 0.1f;
            energyText.SetText("Energy: " + Mathf.RoundToInt(energy) + "/100");
        }
    }
}
