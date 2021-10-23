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
    } // ������ ���� ���� ��ġ ��ȣ

    bool CheckSnapPuzzle()
    {
        for (int i = 0; i < line.Bottom.transform.childCount; i++)
        {
            // ���� �ٴڿ� �ڽ��� ���� ��,
            if (line.Bottom.transform.GetChild(i).childCount != 0)
            {
                continue;
            }
            else if (Vector2.Distance(line.Bottom.transform.GetChild(i).position, transform.position) < snapOffset)
            {
                transform.SetParent(line.Bottom.transform.GetChild(i).transform);
                transform.localPosition = Vector3.zero;
                return true;
            }// snapOffset ���� ���� �� ����� ��ġ�� ��ġ�� ������, �� �ڸ��� ����.
        }
        return false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    } // �巡�� �� ��, ������

    public void OnEndDrag(PointerEventData eventData)
    {
        //������ �ٽ� ����ġ�� ���������� �ڽ��̿��� ���� ������ ��ü�� ����
        if (!CheckSnapPuzzle())
        {
            transform.SetParent(line.Upper.transform);
        }
    }
}
