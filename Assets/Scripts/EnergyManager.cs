using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour
{
    private static float energy;
    [SerializeField]

    private static float energyAcquisitionrate;
    private static float energyCap;

    [SerializeField]
    private GameObject EnergyBar;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = EnergyBar.GetComponent<Slider>();
        energy = 0f;
        energyAcquisitionrate = 0.1f;
        energyCap = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        increaseEnergy();
        slider.value = energy/energyCap;
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
