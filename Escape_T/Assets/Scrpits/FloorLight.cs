using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorLight : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("Player")){
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")){
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
