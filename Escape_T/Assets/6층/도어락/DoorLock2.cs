using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorLock2 : MonoBehaviour
{
	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// 테스트
	public Image Openlock;

	void Start()
	{

	}

	//테스트

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "96")
		{
			//student.isSafeOpened = true;
			// 그냥 내가 해본거 codeTextValue = "9999";
			GameObject.Find("Canvas").transform.GetChild(12).gameObject.SetActive(false);
			GameObject.Find("Canvas-world").transform.GetChild(8).gameObject.SetActive(false);
		}

		if (codeTextValue.Length >= 2)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}
}
