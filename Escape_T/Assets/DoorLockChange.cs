using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLockChange : MonoBehaviour  //��������� �Ѿ�� ��ư(����� ��� Ŭ���� ������� Ȯ��Ǿ ����)
{
    public void Click()
    {
        SceneManager.LoadScene("DoorLockScene");
    }
}