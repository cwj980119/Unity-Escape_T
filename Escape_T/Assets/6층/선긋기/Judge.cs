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

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsClear())
        {
            Debug.Log("Clear");
            GameObject.Find("Canvas").transform.GetChild(5).gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.GetChild(8).gameObject.SetActive(true);
            GameObject.Find("Item").transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
