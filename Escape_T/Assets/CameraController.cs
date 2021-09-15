using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    static public CameraController instance;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {

        if(instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            this.player = GameObject.Find("student");//player ã��
            instance = this;
        }
        else {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position; //playerpos ����
        transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z); //player x,y�� ī�޶� �̵�
    }
}
