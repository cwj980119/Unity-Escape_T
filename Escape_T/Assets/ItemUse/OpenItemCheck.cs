using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItemCheck : MonoBehaviour
{
    [SerializeField]
    public GameObject clickButton;
    public Collider2D usingItemObject;
    private bool haveItem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("UseItem"))
        {
            usingItemObject = collision;
            if(gameObject.GetComponent<Inven>().ItemChk(collision.gameObject.GetComponent<UsingItems>().getItemName())){
                haveItem = true;
                clickButton.SetActive(true);
            }
            else{
                haveItem = false;
                clickButton.SetActive(true);
            }
            
        }
        else if(collision.CompareTag("OpenPanel")){
            usingItemObject = collision;
            clickButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.CompareTag("UseItem")||collision.CompareTag("OpenPanel"))
        {
            usingItemObject = null;
        }
    }

    public void UseItem(){
        clickButton.SetActive(false);
        if(usingItemObject!=null){
            if(usingItemObject.CompareTag("UseItem")){
                //Destroy(usingItemObject.gameObject);
                if(haveItem){
                    usingItemObject.gameObject.SetActive(false);
                }
                else{
                    usingItemObject.gameObject.GetComponent<UsingItems>().panel.SetActive(true);
                }
            }
            else if(usingItemObject.CompareTag("OpenPanel")){
                usingItemObject.gameObject.GetComponent<OpenItemPanel>().OpenPanel();
            }
        }
    }

}
