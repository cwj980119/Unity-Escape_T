using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public static Setting setting;

    private void Update() {
        BackButton();
    }

    public void OpenSetting() //설정 창이 켜졌을 때 환경
    {
        GameObject.Find("SettingCanvas").transform.GetChild(0).gameObject.SetActive(true);
        GameObject.Find("SettingCanvas").transform.Find("Setting").transform.GetChild(5).gameObject.SetActive(true);
    }

    public void CloseSetting() //설정 창을 끈다.
    {
        GameObject.Find("SettingCanvas").transform.GetChild(0).gameObject.SetActive(false);
    }

    private void BackButton(){
        if(Input.GetKey(KeyCode.Escape)){
            OpenSetting();
        }
    } // 뒤로가기 버튼으로 설정 창 띄우기

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
