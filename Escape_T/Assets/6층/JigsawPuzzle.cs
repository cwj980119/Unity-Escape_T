
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JigsawPuzzle : MonoBehaviour
{
    public GameObject PuzzlePosSet;
    public GameObject PuzzlePieceSet;

    public bool IsClear()
    {
        for (int i = 0; i < PuzzlePosSet.transform.childCount; i++)
        {
            //������ġ�� �ڽ��� ������ ��� ���������� �������� �������Դϴ�.
            if (PuzzlePosSet.transform.GetChild(i).childCount == 0)
            {
                return false;
            }
            //���������� ��ȣ�� ���� ��ġ ��ȣ�� ��ġ���� ������ ������ �ϼ����� �������Դϴ�.
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
