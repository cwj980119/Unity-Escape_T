using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItemPanel : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    public void OpenPanel(){
        panel.SetActive(true);
    }
}
