using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    public GameObject panelToClose;
    public GameObject panelToOpen; // new panel to show

    public void CloseUI()
    {
        if (panelToClose != null)
            panelToClose.SetActive(false);

        if (panelToOpen != null)
            panelToOpen.SetActive(true);
    }
}
