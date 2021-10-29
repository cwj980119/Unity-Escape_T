using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Piece : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public int snapOffset = 30;
    public Judge line;
    public int piece_no;

    public void Number()
    {
        piece_no = gameObject.name[gameObject.name.Length - 1] - '0';
    } // 조각에 대해 정답 위치 번호

    bool CheckSnapPuzzle()
    {
        for (int i = 0; i < line.Bottom.transform.childCount; i++)
        {
            // 퍼즐 바닥에 자식이 없을 때,
            if (line.Bottom.transform.GetChild(i).childCount != 0)
            {
                continue;
            }
            else if (Vector2.Distance(line.Bottom.transform.GetChild(i).position, transform.position) < snapOffset)
            {
                transform.SetParent(line.Bottom.transform.GetChild(i).transform);
                transform.localPosition = Vector3.zero;
                return true;
            }// snapOffset 숫자 보다 더 가까운 위치에 위치해 있으면, 그 자리로 들어간다.
        }
        return false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    } // 드래그 할 때, 움직임

    public void OnEndDrag(PointerEventData eventData)
    {
        //퍼즐을 다시 원위치로 돌려놓으면 자식이였던 것이 독립된 개체로 나감
        if (!CheckSnapPuzzle())
        {
            transform.SetParent(line.Upper.transform);
        }
    }
}
