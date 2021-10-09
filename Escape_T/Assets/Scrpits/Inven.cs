using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Inven : MonoBehaviour
{
    #region Singleton
    public static Inven instance;
    private void Awake() {
        if(instance!=null){
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion

    public List<Item> items = new List<Item>();
    public delegate void OnChangeItem();
    public OnChangeItem onChangeItem;
    public GameObject clickButton;
    private FieldItem fielditems;
    private bool chk_field;
    

    public void AddItem(Item _item){
        items.Add(_item);
        if(onChangeItem!=null){
            onChangeItem.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Item")){
            fielditems = other.GetComponent<FieldItem>();
            clickButton.SetActive(true);
            chk_field = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Item")){
            fielditems = null;
            chk_field = false;
        }
            clickButton.SetActive(false);
    }

    public void Get(){
        if(chk_field){
            AddItem(fielditems.GetItem());
            fielditems.DestoryItem();
        }
    }

    public void GetUiItem(){
        fielditems = EventSystem.current.currentSelectedGameObject.GetComponent<FieldItem>();
        AddItem(fielditems.GetItem());
        fielditems.DestoryItem();
    }

    public bool ItemChk(string name){
        for(int i=0;i<items.Count;i++){
            if(items[i].itemName==name) return true;
        }
        return false;
    }
}