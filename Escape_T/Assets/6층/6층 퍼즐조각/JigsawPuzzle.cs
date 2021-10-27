using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JigsawPuzzle : MonoBehaviour
{
    public GameObject PuzzlePosSet;
    public GameObject PuzzlePieceSet;
    public int number1; //���� panel ����
    public int number2; //�� panel ����
    public int number3; //ItemName���� �������� ��ġ
    public string ItemsName;

    public bool IsClear()
    {
        for (int i = 0; i < PuzzlePosSet.transform.childCount; i++)
        {
            if (PuzzlePosSet.transform.GetChild(i).childCount == 0)
            {
                return false;
            }

            if (PuzzlePosSet.transform.GetChild(i).GetChild(0).GetComponent<PuzzlePiece>().piece_no != i)
            {
                return false;
            }
        }
        return true;
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
