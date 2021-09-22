using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image Icon;
    public Text ItemName_Text;
    public Text itemCount_Text;
    public GameObject selected_Item;
   
    public void Additem(Item _item)
    {
        ItemName_Text.text = _item.itemName;
        Icon.sprite = _item.itemIcon;
        if(Item.ItemType.Use==_item.itemType)
        {
            if(_item.itemCount>0)
            {
                itemCount_Text.text = "x " + _item.itemCount.ToString();
            }
            else
            {
                itemCount_Text.text = "";
            }
        }
    }

    public void RemoveItem()
    {
        ItemName_Text.text = "";
        itemCount_Text.text = "";
        Icon.sprite = null;
    }
}
