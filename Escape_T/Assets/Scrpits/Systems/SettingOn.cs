using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingOn : MonoBehaviour
{
    public void SettingButtonKeepOn() //����ȭ�� - �ٸ� �� - ����ȭ���� ������ ���� ����
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
