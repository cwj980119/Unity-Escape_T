using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

	public static bool invectoryActivated = false;  // �κ��丮 Ȱ��ȭ ����. true�� �Ǹ� ī�޶� �����Ӱ� �ٸ� �Է��� ���� ���̴�.

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

	void Update()
	{
		TryOpenInventory();
	}

	private void TryOpenInventory()
	{
		if (Input.GetKeyDown(KeyCode.H))
		{
			invectoryActivated = !invectoryActivated;

			if (invectoryActivated)
				OpenInventory();
			else
				CloseInventory();

		}
	}

	private void OpenInventory()
	{
		BackGround.SetActive(true);
	}

	private void CloseInventory()
	{
		BackGround.SetActive(false);
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