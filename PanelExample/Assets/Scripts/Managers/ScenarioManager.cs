using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScenarioManager : MonoBehaviour
{


    public Scenario[] scenarios; // Senaryoları tutacak dizi
    public int currentScenarioIndex; // Mevcut senaryo indeksi

    void Start()
    {
        currentScenarioIndex = 0; // Başlangıç indeksi
        UpdateScenario(); // İlk senaryoyu göster


    }

    void UpdateScenario()
    {
        if (currentScenarioIndex >= 0 && currentScenarioIndex < scenarios.Length)
        {
            foreach (Scenario scenario in scenarios)
            {

                Debug.Log(scenario.SequenceNumber);
            }
        }
    }

    void PreviousScenario()
    {
        if (currentScenarioIndex > 0)
        {
            currentScenarioIndex--;
            UpdateScenario();
        }
    }

    void NextScenario()
    {
        if (currentScenarioIndex < scenarios.Length - 1)
        {
            currentScenarioIndex++;
            UpdateScenario();
        }
    }
}
