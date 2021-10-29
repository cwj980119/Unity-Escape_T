using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public GameObject Bottom; //퍼즐 밑바닥
    public GameObject Upper; //퍼즐 조각

    public bool IsClear()
    {
        for (int i = 0; i < Bottom.transform.childCount; i++)
        {
            //Bottom에 자식이 없으면 조각이 놓여있지 않는 것
            if (Bottom.transform.GetChild(i).childCount == 0)
            {
                return false;
            }
            //정확한 위치에 퍼즐이 없으면 잘못된 것
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
