using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ProcedureManager : MonoBehaviour
{
    public TextMeshProUGUI procedureText; // Tek bir TextMeshPro nesnesi
    public Button previousButton; // "Previous" butonu
    public Button nextButton; // "Next" butonu

    public Procedure[] procedures; // Prosedürleri tutacak dizi
    public int currentProcedureIndex; // Mevcut prosedür indeksi

    void Start()
    {
        currentProcedureIndex = 0; // Başlangıç indeksi
        UpdateProcedure(); // İlk prosedürü göster

        // Butonlara tıklama olaylarını ekle
        previousButton.onClick.AddListener(PreviousProcedure);
        nextButton.onClick.AddListener(NextProcedure);
    }

    void UpdateProcedure()
    {
        if (currentProcedureIndex >= 0 && currentProcedureIndex < procedures.Length)
        {
            procedureText.text = procedures[currentProcedureIndex].Content; // Prosedür içeriğini göster
        }
    }

    void PreviousProcedure()
    {
        if (currentProcedureIndex > 0)
        {
            currentProcedureIndex--;
            UpdateProcedure();
        }
    }

    void NextProcedure()
    {
        if (currentProcedureIndex < procedures.Length - 1)
        {
            currentProcedureIndex++;
            UpdateProcedure();
        }
    }
}
