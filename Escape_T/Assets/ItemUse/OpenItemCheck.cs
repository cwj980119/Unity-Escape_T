using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItemCheck : MonoBehaviour
{
    [SerializeField]
    public GameObject clickButton;
    private Collider2D usingItemObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("UseItem"))
        {
            usingItemObject = collision;
            if(gameObject.GetComponent<Inven>().ItemChk(collision.gameObject.GetComponent<UsingItems>().getItemName())){
                Debug.Log("111");
                clickButton.SetActive(true);
            }
            
        }
        else if(collision.CompareTag("OpenPanel")){
            usingItemObject = collision;
            clickButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.CompareTag("UseItem"))
        {
            usingItemObject = null;
        }
    }

    public void UseItem(){
        clickButton.SetActive(false);
        if(usingItemObject.CompareTag("UseItem")){
            //Destroy(usingItemObject.gameObject);
            usingItemObject.gameObject.SetActive(false);
        }
        else if(usingItemObject.CompareTag("OpenPanel")){
            usingItemObject.gameObject.GetComponent<OpenItemPanel>().OpenPanel();
        }
    }

}
