using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorLight : MonoBehaviour
{
    //if the player is in the room turn on the light

    //when player is staying in the room, turn on the light
    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("Player")){
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    //when go out, turn off the light
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")){
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
