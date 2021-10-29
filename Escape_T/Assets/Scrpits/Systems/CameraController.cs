using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    static public CameraController instance;
    GameObject player;

    // get player object & set DontDestoryOnLoad
    void Start()
    {

        if(instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            this.player = GameObject.Find("student");//player object
            instance = this;
        }
        else {
            Destroy(this.gameObject);
        }
    }

    // follow player position
    void Update()
    {
        Vector3 playerPos = this.player.transform.position; //get playerPos
        transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z); //set cameraPos to playerPos
    }
}
