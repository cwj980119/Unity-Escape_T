using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JigsawPuzzle : MonoBehaviour
{
    public GameObject PuzzlePosSet;
    public GameObject PuzzlePieceSet;
    public int number1; //닫을 panel 순번
    public int number2; //열 panel 순번
    public int number3; //ItemName에서 아이템의 위치
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
