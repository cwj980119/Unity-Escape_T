using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingClick : MonoBehaviour
{
    private Setting setting;
    public void SettingButtonClick()
    {
            setting.OpenSetting();
    }
    // Start is called before the first frame update
    void Start()
    {
        setting = GameObject.Find("SettingCanvas").GetComponent<Setting>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
