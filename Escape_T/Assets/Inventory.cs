using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

	public List<Item> items; // �������� ���� ����Ʈ

	[SerializeField]
	private Transform slotParent; // BackGround�� ��� ��
	[SerializeField]
	private Slot[] slots; //Slot�� ��� ��
	[SerializeField]
	private GameObject BackGround; // Inventory_Base �̹���

	private void OnValidate() //����Ƽ �����Ϳ��� �ٷ� �۵�(���Կ� Slot�� �ڵ� ��ϵȴ�.)
	{
		slots = slotParent.GetComponentsInChildren<Slot>();
	}

	void Awake() // �����ϸ� items�� ��� �ִ� �������� �κ��丮�� �ִ´�.
	{
		FreshSlot();
	}

	public void FreshSlot() // �������� �����ų� ������ slot�� ������ �ٽ� �����Ͽ� ȭ�鿡 �����ش�.
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

	public void AddItem(Item _item) // �������� ȹ���� ��쿡 �ҷ��� �ִ� ��
	{
		if (items.Count < slots.Length)
		{
			items.Add(_item); FreshSlot();
		}
		else
		{
			print("������ ���� �� �ֽ��ϴ�.");
		}
	}
}