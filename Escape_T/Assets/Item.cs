using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemID; //아이템 일련번호
    public string itemName; // 아이템 이름
    public string itemDescription; //아이템 설명
    public int itemCount; //아이템 개수
    public Sprite itemIcon; //아이템 모양(그림)
    public ItemType itemType; //아이템 종류

    public enum ItemType
    {
        Use, // 소모품
        Equip, // 장비
        Install, // 설치
        ETC //기타
    }

    public Item(int _itemID, string _itemName, string _itemDes, ItemType _itemType, int _itemCount=1)
    {
        itemID = _itemID;
        itemName = _itemName;
        itemDescription = _itemDes;
        itemType = _itemType;
        itemCount = _itemCount;
        itemIcon = Resources.Load("ItemIcon/" + _itemID.ToString(), typeof(Sprite)) as Sprite;

    }
}
