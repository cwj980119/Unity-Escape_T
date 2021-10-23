using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePiece : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public int snapOffset = 30;
    public JigsawPuzzle puzzle;
    public int piece_no;

    public void Number()
    {
        piece_no = gameObject.name[gameObject.name.Length - 1] - '0';
    }

    bool CheckSnapPuzzle()
    {
        for (int i = 0; i < puzzle.PuzzlePosSet.transform.childCount; i++)
        {
            if (puzzle.PuzzlePosSet.transform.GetChild(i).childCount != 0)
            {
                continue;
            }
            else if (Vector2.Distance(puzzle.PuzzlePosSet.transform.GetChild(i).position, transform.position) < snapOffset)
            {
                transform.SetParent(puzzle.PuzzlePosSet.transform.GetChild(i).transform);
                transform.localPosition = Vector3.zero;
                return true;
            }
        }
        return false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!CheckSnapPuzzle())
        {
            transform.SetParent(puzzle.PuzzlePieceSet.transform);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (puzzle.IsClear())
        {
            Debug.Log("Clear");
            GameObject.Find("Canvas").transform.GetChild(puzzle.number1).gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.GetChild(puzzle.number2).gameObject.SetActive(true);
            GameObject.Find(puzzle.ItemsName).transform.GetChild(puzzle.number3).gameObject.SetActive(true);
        }
    }
}
