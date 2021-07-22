using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

	public List<Item> items; // 아이템을 담을 리스트

	[SerializeField]
	private Transform slotParent; // BackGround을 담는 곳
	[SerializeField]
	private Slot[] slots; //Slot을 담는 곳
	[SerializeField]
	private GameObject BackGround; // Inventory_Base 이미지

	private void OnValidate() //유니티 에디터에서 바로 작동(슬롯에 Slot이 자동 등록된다.)
	{
		slots = slotParent.GetComponentsInChildren<Slot>();
	}

	void Awake() // 시작하면 items에 들어 있는 아이템을 인벤토리에 넣는다.
	{
		FreshSlot();
	}

	public void FreshSlot() // 아이템이 들어오거나 나오면 slot의 내용을 다시 정리하여 화면에 보여준다.
	{
		int i = 0;
		for (; i < items.Count && i < slots.Length; i++)
		{
			slots[i].item = items[i];
		}
		for (; i < slots.Length; i++)
		{
			slots[i].item = null;
		}
	}

	public void AddItem(Item _item) // 아이템을 획득할 경우에 불러와 넣는 것
	{
		if (items.Count < slots.Length)
		{
			items.Add(_item); FreshSlot();
		}
		else
		{
			print("슬롯이 가득 차 있습니다.");
		}
	}
}