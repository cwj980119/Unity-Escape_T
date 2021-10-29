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

    // ���� ������ ȹ�� �� �Ҹ� ���� �Ϸ��� ����
    [SerializeField]
    AudioController audio_controller;
    // ���� ������ ȹ�� �� �Ҹ� ���� �Ϸ��� ����

    //add the fielditem to the inventory 
    public void AddItem(Item _item){
        items.Add(_item);
        // ���� ������ ȹ�� �Ҹ� ���� �Ϸ��� ����
        audio_controller.EffectSoundOn(1);  //getting item soundeffect
        // ���� ������ ȹ�� �Ҹ� ���� �Ϸ��� ����
        if (onChangeItem!=null){
            onChangeItem.Invoke();
        }
    }

    //remove a specific item from items List
    public void RemoveItem(string usingitem){   
        for(int i = items.Count - 1; i >= 0; i--) {
            if(items[i].itemName==usingitem){
                items.Remove(items[i]);
                return;
            }
        }
    }

    //remove items all on the list
    public void RemoveItemsAll(){
        for(int i = items.Count -1; i>=0;i--){
            items.Remove(items[i]);
        }
    }

    //if object is item ready to add item
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Item")){
            fielditems = other.GetComponent<FieldItem>();   //fielditem set
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

    //check collider before add a item 
    public void Get(){
        if(chk_field){
            AddItem(fielditems.GetItem());
            fielditems.DestoryItem();
        }
    }

    //add a UIitem with a click
    public void GetUiItem(){
        fielditems = EventSystem.current.currentSelectedGameObject.GetComponent<FieldItem>();
        AddItem(fielditems.GetItem());
        fielditems.DestoryItem();
    }

    //check if the item "name" is on the list
    public bool ItemChk(string name){
        for(int i=0;i<items.Count;i++){
            if(items[i].itemName==name) return true;
        }
        return false;
    }

    private void Start()
    {
        audio_controller = GameObject.Find("Music").GetComponent<AudioController>();
    }
}