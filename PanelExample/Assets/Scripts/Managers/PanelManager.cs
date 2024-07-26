using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class PanelManager : Singleton<PanelManager>
{
    //the list of all panels avaible for our manager
    public List<PanelModel> panels;

    private Queue<PanelInstanceModel> _queue = new Queue<PanelInstanceModel>();

    public GameObject firstPanelPrefab;

    private void Start()
    {
        var firstInstantiateModel = Instantiate(firstPanelPrefab, transform);

        _queue.Enqueue(new PanelInstanceModel
        {
            PanelName = "MainMenu",
            PanelInstance = firstInstantiateModel,

        });
    }

    public void ShowPanel(string panelName)
    {
        PanelModel panelModel = panels.FirstOrDefault(panel => panel.PanelName == panelName);

        if (panelModel != null) 
        { 
            //we have our panel

            var newInstancePanel = Instantiate(panelModel.PanelPrefab, transform);

            _queue.Enqueue(new PanelInstanceModel
            {
                PanelName = panelName,
                PanelInstance = newInstancePanel

            });
        }
        else
        {
            Debug.Log("Panel is not found");
        }
    }

    public void HideLastPanel()
    {
        if (AnyPanelShowing())
        {
            var lastPanel = _queue.Dequeue();
            Destroy(lastPanel.PanelInstance);

        } 
    }

    public bool AnyPanelShowing()
    {
        return GetAmountPanelsInQueue() > 0;
    }

    public int GetAmountPanelsInQueue()
    {
        return _queue.Count;
    }


}
