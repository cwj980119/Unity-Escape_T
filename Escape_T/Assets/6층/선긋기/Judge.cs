using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public GameObject Bottom;
    public GameObject Upper;

    public bool IsClear()
    {
        for (int i = 0; i < Bottom.transform.childCount; i++)
        {
            //������ġ�� �ڽ��� ������ ��� ���������� �������� �������Դϴ�.
            if (Bottom.transform.GetChild(i).childCount == 0)
            {
                return false;
            }
            //���������� ��ȣ�� ���� ��ġ ��ȣ�� ��ġ���� ������ ������ �ϼ����� �������Դϴ�.
            if (Bottom.transform.GetChild(i).GetChild(0).GetComponent<Piece>().piece_no != i)
            {
                return false;
            }
        }
        return true;
    }

    public bool LineAppear()
    {
        if (Bottom.transform.GetChild(0).GetChild(0).GetComponent<Piece>().piece_no == 0)
        {
            if (Bottom.transform.GetChild(4).GetChild(0).GetComponent<Piece>().piece_no == 6)
            {
                GameObject.Find("Line").transform.GetChild(0).gameObject.SetActive(true);
            }
        }

        if (Bottom.transform.GetChild(1).GetChild(0).GetComponent<Piece>().piece_no == 1)
        {
            if (Bottom.transform.GetChild(5).GetChild(0).GetComponent<Piece>().piece_no == 5)
            {
                GameObject.Find("Line").transform.GetChild(1).gameObject.SetActive(true);
            }
        }

        if (Bottom.transform.GetChild(2).GetChild(0).GetComponent<Piece>().piece_no == 2)
        {
            if (Bottom.transform.GetChild(6).GetChild(0).GetComponent<Piece>().piece_no == 7)
            {
                GameObject.Find("Line").transform.GetChild(2).gameObject.SetActive(true);
            }
        }

        if (Bottom.transform.GetChild(3).GetChild(0).GetComponent<Piece>().piece_no == 3)
        {
            if (Bottom.transform.GetChild(7).GetChild(0).GetComponent<Piece>().piece_no == 4)
            {
                GameObject.Find("Line").transform.GetChild(3).gameObject.SetActive(true);
            }
        }
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LineAppear();

        if (IsClear())
        {
            Debug.Log("Clear");
            GameObject.Find("Canvas").transform.GetChild(8).gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.GetChild(9).gameObject.SetActive(false);
        }
    }
}
