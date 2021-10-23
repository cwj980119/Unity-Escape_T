using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingOn : MonoBehaviour
{
    public void SettingButtonKeepOn() //메인화면 - 다른 층 - 메인화면을 나갈때 버그 수정
    {
        GameObject.Find("SettingCanvas").transform.Find("Setting").gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
