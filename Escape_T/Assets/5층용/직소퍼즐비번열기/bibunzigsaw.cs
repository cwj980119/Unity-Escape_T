using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bibunzigsaw : MonoBehaviour
{

	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// 테스트
	public Image Openlock;

	void Start()
	{
		Openlock.enabled = false;
	}

	//테스트

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "1234")
		{
			//student.isSafeOpened = true;
			// 그냥 내가 해본거 codeTextValue = "9999";
			Openlock.enabled = true;
		}

		if (codeTextValue.Length >= 4)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}
