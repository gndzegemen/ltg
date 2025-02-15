using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelButton : MonoBehaviour
{
    public string PanelName;

    private PanelManager _panelManager;

    private void Start()
    {
        _panelManager = PanelManager.Instance;
    }

    public void DoShowPanel()
    {
        _panelManager.ShowPanel(PanelName);
    }
}
