using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorLock : MonoBehaviour
{

	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// �׽�Ʈ
	public Image Openlock;

	void Start()
	{
		
	}

	//�׽�Ʈ

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "1234")
		{
			//student.isSafeOpened = true;
			// �׳� ���� �غ��� codeTextValue = "9999";
			GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(false);
			GameObject.Find("Canvas").transform.GetChild(3).gameObject.SetActive(true);
		}

		if (codeTextValue.Length >= 4)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}
