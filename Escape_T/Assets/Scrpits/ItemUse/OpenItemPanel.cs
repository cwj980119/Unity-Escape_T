using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItemPanel : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    private Collider2D player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player"))
        {
            player = collision;
            
        }

    }

    private void OnTriggerExit2D(Collider2D collision){
        player = null;
    }

    public void GetUiItem(){
        if(player!=null){
            player.gameObject.GetComponent<Inven>().GetUiItem();
        }
    }

    public void OpenPanel(){
        panel.SetActive(true);
    }
}
