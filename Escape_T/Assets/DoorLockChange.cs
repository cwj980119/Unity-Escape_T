using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLockChange : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("DoorLockScene");
    }
}