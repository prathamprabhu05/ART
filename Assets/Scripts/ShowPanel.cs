using UnityEngine;
using System.Collections.Generic; // Important: for List<GameObject>

public class ShowPanel : MonoBehaviour
{
    public GameObject panelToShow;
    public List<GameObject> otherPanelsToHide; // List to hold references to other panels

    public void ShowSpecificPanel() // Renamed for clarity, can be ShowTeleportPanel, ShowRotateViewPanel
    {
        // 1. Hide all other panels in the list
        foreach (GameObject panel in otherPanelsToHide)
        {
            if (panel != null && panel.activeSelf) // Only hide if it's currently active
            {
                panel.SetActive(false);
            }
        }

        // 2. Show the target panel
        if (panelToShow != null)
        {
            panelToShow.SetActive(true);
        }
    }
}