using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorLockAppear : MonoBehaviour
{
    Vector2 MousePosition;
    Vector2 doorLocate;
    GameObject door;

    void Start()
    {
        door = GameObject.Find("door5");
        doorLocate = this.door.transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MousePosition = Input.mousePosition;

            if (doorLocate == MousePosition)
            {
                GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(true);
            }
        }   
    }
}