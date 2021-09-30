using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    

    public void AddItem(Item _item){
        items.Add(_item);
        if(onChangeItem!=null){
            onChangeItem.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Item")){
            FieldItem fielditems = other.GetComponent<FieldItem>();
            AddItem(fielditems.GetItem());
            fielditems.DestoryItem();
        }
    }
}