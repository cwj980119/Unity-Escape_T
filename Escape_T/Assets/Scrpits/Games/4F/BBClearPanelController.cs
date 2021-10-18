using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBClearPanelController : MonoBehaviour
{
    public void PanelOn(){
        gameObject.SetActive(true);
    }

    public void PanelOff(){
        gameObject.SetActive(false);
    }
}
