using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public void OpenSetting()
    {
        Time.timeScale = 0;
        GameObject.Find("student").transform.Find("SettingCanvas").transform.GetChild(0).gameObject.SetActive(true);
    }

    public void CloseSetting()
    {
        Time.timeScale = 1;
        GameObject.Find("student").transform.Find("SettingCanvas").transform.GetChild(0).gameObject.SetActive(false);
    }

}
