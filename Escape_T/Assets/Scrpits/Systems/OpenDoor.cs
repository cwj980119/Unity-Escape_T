using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject instance;

    //Open the door for 2 seconds
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "student")
        {
            instance.SetActive(false);
            Invoke("Close",2);
        }
    }

    void Close(){
        instance.SetActive(true);
    }
}
