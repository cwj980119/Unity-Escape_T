using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public GameObject move_point;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player"))
        {
            collision.transform.position = move_point.transform.position;
        }

    }
}
