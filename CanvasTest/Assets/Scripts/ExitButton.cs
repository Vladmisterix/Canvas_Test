using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public GameObject Panel, buttonSettings, buttonStart, exitButton;

    public void OnClickButton()
    {
        Panel.SetActive(false);
        exitButton.SetActive(false);
        buttonSettings.SetActive(true);
        buttonStart.SetActive(true);
    }
}

