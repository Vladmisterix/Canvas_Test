using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonFromSetting : MonoBehaviour
{
    public GameObject exitButtonFromSetting, buttonSettings, buttonStart;

    public void OnClickButton()
    {
        exitButtonFromSetting.SetActive(false);
        buttonSettings.SetActive(true);
        buttonStart.SetActive(true);
    }
}
