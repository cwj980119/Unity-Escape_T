using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSave : MonoBehaviour
{
    GameObject datacontrol;
    GameObject player;
    public int stage;

    void Start()
    {
        datacontrol = GameObject.Find("Data");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player"))
        {
            player = collision.gameObject;
            SaveStage();
            ClearInventory();
        }

    }

    private void SaveStage(){
        switch (stage)
        {
            case 3:
                datacontrol.GetComponent<DataController>().gameData.isClear3 =true;
                break;
            case 4:
                datacontrol.GetComponent<DataController>().gameData.isClear4 =true;
                break;
            case 5:
                datacontrol.GetComponent<DataController>().gameData.isClear5 =true;
                break;
            case 6:
                datacontrol.GetComponent<DataController>().gameData.isClear6 =true;
                break;
            case 7:
                datacontrol.GetComponent<DataController>().gameData.isClear7 =true;
                break;
            
            default:
                break;
        }
    }

    private void ClearInventory(){
        player.GetComponent<Inven>().RemoveItemsAll();
    }
}
