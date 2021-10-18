using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Inven inven;

    public GameObject inventoryPanel;
    bool active = false;
    public bool expand = false;
    
    public Slot[] slots;
    public Transform slotHolder;
    
    private void Start() {
        inven = Inven.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        inven.onChangeItem += RedrawSlotUI;
        for(int i=0;i<slots.Length;i++){
            slots[i].RemoveSlot();
        }
        inventoryPanel.SetActive(active);
    }
    
    //when click inventory open or close
    public void ShowInventory(){
        active = !active;
        inventoryPanel.SetActive(active);
    }

    //draw items image on the inventory
    void RedrawSlotUI(){
        for(int i=0;i<slots.Length;i++){
            slots[i].RemoveSlot();
        }
        for(int i=0;i<inven.items.Count;i++){
            slots[i].item = inven.items[i];
            slots[i].UpdateSlot();
        }
    }

    private void Update() {
        RedrawSlotUI();
    }
}
