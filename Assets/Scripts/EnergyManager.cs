using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class EnergyManager : MonoBehaviour
{
    private static float energy;
    [SerializeField]
    private TextMeshProUGUI energyText;
    private static float energyAcquisitionrate;
    private static float energyCap;
    // Start is called before the first frame update
    void Start()
    {
        energy = 50f;
        energyAcquisitionrate = 0.1f;
        energyCap = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        increaseEnergy();
    }
    void increaseEnergy()
    {
        if (energy > energyCap)
        {
            energy = energyCap;
        }
        else
        {
            energy += energyAcquisitionrate;
            energyText.SetText("Energy: " + Mathf.RoundToInt(energy) + "/" + energyCap);
        }
    }
    public static void increaseAcquisitionrate(float rate)
    {
        energyAcquisitionrate = energyAcquisitionrate * (1.0f + rate);
    }
    public static void fillEnergyToCap()
    {
        energy = energyCap;
    }
    public static void increaseEnergyCap ()
    {
        energyCap += 10.0f;
    }
}
