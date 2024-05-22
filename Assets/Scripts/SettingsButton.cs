using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public GameObject exitButtonFromSetting, buttonSettings, buttonStart;

    public void OnClickButton()
    {
        exitButtonFromSetting.SetActive(true);
        buttonSettings.SetActive(false);
        buttonStart.SetActive(false);
    }
}
