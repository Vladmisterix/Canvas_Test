using Unity.VisualScripting;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject Panel, buttonSettings, buttonStart, exitButton;

    public void OnClickButton()
    {
        Panel.SetActive(true);
        exitButton.SetActive(true);
        buttonSettings.SetActive(false);
        buttonStart.SetActive(false);
    }
   
}
