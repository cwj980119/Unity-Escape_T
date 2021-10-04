using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorLockQuiz : MonoBehaviour
{

	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// �׽�Ʈ
	public Image Open;

	void Start()
	{
		Openlock.enabled = false;
	}

	//�׽�Ʈ

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "369")
		{
			//student.isSafeOpened = true;
			// �׳� ���� �غ��� codeTextValue = "9999";
			Openlock.enabled = true;
		}

		if (codeTextValue.Length >= 3)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}
