using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideTalk : MonoBehaviour
{
    public GameObject talk_canvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player"))
        {
            talk_canvas.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }

    }
}
