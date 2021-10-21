using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItemCheck : MonoBehaviour
{
    [SerializeField]
    public GameObject clickButton;
    public GameObject instance;
    public Collider2D usingItemObject;
    private bool haveItem; //check item

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("UseItem")||collision.CompareTag("UseItemKeep"))
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
            if(usingItemObject.CompareTag("UseItem")){  //remove item from inventory
                //Destroy(usingItemObject.gameObject);
                if(haveItem){
                    gameObject.GetComponent<Inven>().RemoveItem(usingItemObject.GetComponent<UsingItems>().getItemName());
                    //Debug.Log(usingItemObject.GetComponent<UsingItems>().getItemName());
                    usingItemObject.gameObject.SetActive(false);
                }
                else{
                    usingItemObject.gameObject.GetComponent<UsingItems>().panel.SetActive(true);
                }
            }
            else if (usingItemObject.CompareTag("UseItemKeep")){  //dont remove item
                if(haveItem){
                    //Debug.Log(usingItemObject.GetComponent<UsingItems>().getItemName());
                    usingItemObject.gameObject.SetActive(false);
                    instance = usingItemObject.gameObject;
                    Invoke("Close",2);
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

    void Close(){
        instance.SetActive(true);
    }

}
