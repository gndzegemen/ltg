using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModuleManager : MonoBehaviour
{
    public Module[] modules; // Modülleri tutacak dizi
    public GameObject buttonPrefab; // Buton prefabı
    public Transform buttonParent; // Butonların yerleştirileceği parent (GridLayoutGroup içermeli)

    void Start()
    {
        CreateModuleButtons(); // Modül butonlarını oluştur
    }

    void CreateModuleButtons()
    {
        foreach (Module module in modules)
        {
            GameObject button = Instantiate(buttonPrefab, buttonParent);
            button.GetComponentInChildren<Text>().text = $"Module {module.SequenceNumber}";
            button.GetComponent<Button>().onClick.AddListener(() => OnModuleButtonClicked(module));
        }
    }

    void OnModuleButtonClicked(Module module)
    {
        // Module tıklandığında ne yapılacaksa burada yapılır
        Debug.Log($"Module {module.SequenceNumber} clicked. GUID: {module.GUID}");
    }
}
