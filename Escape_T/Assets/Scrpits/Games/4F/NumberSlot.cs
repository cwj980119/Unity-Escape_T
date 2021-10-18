using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NumberSlot : MonoBehaviour,IDropHandler
{
    GameObject gamecontroller;
    public int slot;
    public int num = -1;
    public bool exist = true;
    private void Start() {
        gamecontroller = GameObject.Find("Panel");
    }


    public void OnDrop(PointerEventData eventData) {
        if(eventData.pointerDrag != null&&exist) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<NumberDD>().onSlot = true;
            num=eventData.pointerDrag.GetComponent<NumberDD>().number;
            exist = false;
            setAns();
        }
        else if(!exist){
            eventData.pointerDrag.GetComponent<NumberDD>().InitLoc();
        }
        Debug.Log(num);
        
    }

    public void setAns(){
        if(num!=-1){
            if(slot==1){
                gamecontroller.GetComponent<NumberGameController>().SetAnsA(num);
            }
            else if(slot==2){
                gamecontroller.GetComponent<NumberGameController>().SetAnsB(num);
            }
            else if(slot==3){
                gamecontroller.GetComponent<NumberGameController>().SetAnsC(num);
            }
        }
    }
}
