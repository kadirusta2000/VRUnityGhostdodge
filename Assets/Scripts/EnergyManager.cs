using System.Collections;
using System.Collections.Generic;
using TMPro;
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
            energy = 100;
        }
        else
        {
            energy += 0.1f;
            energyText.SetText("Energy: " + energy + "/100");
        }
    }
}
