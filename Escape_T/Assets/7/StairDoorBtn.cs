using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StairDoorBtn : MonoBehaviour  //��������� �Ѿ�� ��ư(����� ��� Ŭ���� ������� Ȯ��Ǿ ����)
{
    public void Click()
    {
        SceneManager.LoadScene("StairDoorLockScene");
    }
}