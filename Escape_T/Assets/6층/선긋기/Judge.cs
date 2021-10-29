using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public GameObject Bottom; //���� �عٴ�
    public GameObject Upper; //���� ����

    public bool IsClear()
    {
        for (int i = 0; i < Bottom.transform.childCount; i++)
        {
            //Bottom�� �ڽ��� ������ ������ �������� �ʴ� ��
            if (Bottom.transform.GetChild(i).childCount == 0)
            {
                return false;
            }
            //��Ȯ�� ��ġ�� ������ ������ �߸��� ��
            if (Bottom.transform.GetChild(i).GetChild(0).GetComponent<Piece>().piece_no != i)
            {
                return false;
            }
        }
        return true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsClear())
        {
            Debug.Log("Clear");
            GameObject.Find("ComputerCanvas").transform.GetChild(1).gameObject.SetActive(false);
            GameObject.Find("ComputerCanvas").transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}
