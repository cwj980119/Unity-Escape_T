using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public GameObject move_point;
    //
    public GameObject panel;
    //

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player"))
        {
            //
            panel.gameObject.SetActive(true);
            //
            collision.transform.position = move_point.transform.position;
        }

    }
}
