using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public int itemCount;
    [SerializeField] Image image; // Image Component�� ���� ��

    private Item _item;
    public Item item
    {
        get // ������ item ������ �ѱ� ��
        {
            return _item;
        }

        set // item�� ���� ������ _item�� �����
        {
            _item = value;
            if (_item != null) // Item=null�� �ƴϸ� �׹�° ��ǥ�� 1�� �̹��� ǥ��, �� �ܴ� 0���� ǥ�� ����
            {
                image.sprite = item.itemImage;
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }
}
