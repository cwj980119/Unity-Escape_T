using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        this.player = GameObject.Find("student");//player 찾기
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position; //playerpos 저장
        transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z); //player x,y로 카메라 이동
    }
}
