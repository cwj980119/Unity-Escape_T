using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JigsawPuzzle : MonoBehaviour
{
    public GameObject PuzzlePosSet;
    public GameObject PuzzlePieceSet;
    public int number1;
    public int number2;
    public int number3;
    public string ItemsName;

    public bool IsClear()
    {
        for (int i = 0; i < PuzzlePosSet.transform.childCount; i++)
        {
            //퍼즐위치의 자식이 없으면 모든 퍼즐조각이 놓여지지 않은것입니다.
            if (PuzzlePosSet.transform.GetChild(i).childCount == 0)
            {
                return false;
            }
            //퍼즐조각의 번호와 퍼즐 위치 번호가 일치하지 않으면 퍼즐은 완성되지 않은것입니다.
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
