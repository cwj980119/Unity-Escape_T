using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dbdb : MonoBehaviour
{

	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// �׽�Ʈ
	public Image Openlock;

	void Start()
	{
		Openlock.enabled = true;

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

			Openlock.enabled = false;

		}

		if (codeTextValue.Length >= 4)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}