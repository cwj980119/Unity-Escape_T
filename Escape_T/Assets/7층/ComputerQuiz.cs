using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerQuiz : MonoBehaviour
{

	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// �׽�Ʈ
	public Image Openlock;

	void Start()
	{
		Openlock.enabled = false;
	}

	//�׽�Ʈ

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "46")
		{
			Openlock.enabled = true;
		}

		if (codeTextValue.Length >= 2)
			codeTextValue = "";

	}


	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}