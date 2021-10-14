using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public static Setting setting;

    private void Update() {
        BackButton();
    }

    public void OpenSetting()
    {
        GameObject.Find("SettingCanvas").transform.GetChild(0).gameObject.SetActive(true);
        GameObject.Find("SettingCanvas").transform.Find("Setting").transform.GetChild(5).gameObject.SetActive(true);
    }

    public void CloseSetting()
    {
        GameObject.Find("SettingCanvas").transform.GetChild(0).gameObject.SetActive(false);
    }

    private void BackButton(){
        if(Input.GetKey(KeyCode.Escape)){
            OpenSetting();
        }
    }

    void Start()
    {
        if (setting == null)
        {
            DontDestroyOnLoad(this.gameObject);
            setting = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
