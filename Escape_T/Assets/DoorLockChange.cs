using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLockChange : MonoBehaviour  //도어락으로 넘어가는 버튼(도어락 모양 클릭시 도어락이 확대되어서 나옴)
{
    public void Click()
    {
        SceneManager.LoadScene("DoorLockScene");
    }
}