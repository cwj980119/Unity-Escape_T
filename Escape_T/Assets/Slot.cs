using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public int itemCount;
    [SerializeField] Image image; // Image Component을 담을 곳

    private Item _item;
    public Item item
    {
        get // 슬롯의 item 정보를 넘길 때
        {
            return _item;
        }

        set // item에 들어온 정보는 _item에 저장됨
        {
            _item = value;
            if (_item != null) // Item=null이 아니면 네번째 좌표값 1로 이미지 표시, 그 외는 0으로 표시 안함
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
