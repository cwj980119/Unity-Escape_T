using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;
    public Image itemIcon;
    private bool ImageExpand = true;
    Transform child;
    Vector3 position,expandPosition;
    GameObject InvenCanvas;

    private void Start() {
        child = gameObject.transform.GetChild(0);
        position = expandPosition = child.transform.localPosition;
        InvenCanvas = GameObject.Find("InventoryCanvas");
    }

    public void UpdateSlot(){
        itemIcon.sprite = item.itemImage;
        itemIcon.gameObject.SetActive(true);
    } 

    public void RemoveSlot(){
        item = null;
        itemIcon.gameObject.SetActive(false);
    } 

    public void ExpandImage(){
        if(!InvenCanvas.GetComponent<Inventory>().expand){
            ImageExpand = !ImageExpand;
            if(ImageExpand&&child.gameObject.activeSelf == true){
                child.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 100);
                child.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100);
                child.transform.localPosition = position;
                InvenCanvas.GetComponent<Inventory>().expand = false;
            }
            else{
                child.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 1000);
                child.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 1000);
                expandPosition.x = 400;
                expandPosition.y = -400;
                child.transform.localPosition = expandPosition;
                InvenCanvas.GetComponent<Inventory>().expand = true;
            }

        }
        else{
            if(!ImageExpand){
                ImageExpand = !ImageExpand;
                child.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 100);
                child.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100);
                child.transform.localPosition = position;
                InvenCanvas.GetComponent<Inventory>().expand = false;
            }
        }
    }
}
