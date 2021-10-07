using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject gameObject;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "student")
        {
            gameObject.SetActive(false);
            Invoke("Close",2);
        }
    }

    void Close(){
        gameObject.SetActive(true);
    }
}
