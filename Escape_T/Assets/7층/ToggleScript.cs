using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    [SerializeField]
    Toggle[] ToggleButton;
    public GameObject Door;
    public GameObject Canvas1,Canvas2;
    //1378
    private void Update() {
       Door.SetActive(!Check());
       Canvas1.SetActive(!Check());
       Canvas2.SetActive(!Check());
    }
    // public void Toggle(){
    //     if(ToggleButton.Toggle.isOn){
    //         Image.SetActive(To)
    //     }
    // }
    private bool Check(){
        if(ToggleButton[0].isOn&&ToggleButton[2].isOn&&ToggleButton[6].isOn&&ToggleButton[7].isOn){
            if(ToggleButton[1].isOn||ToggleButton[3].isOn||ToggleButton[4].isOn||ToggleButton[5].isOn||ToggleButton[8].isOn){
                return false;
            }
            return true;
        }
        
        return false;
    }
}
