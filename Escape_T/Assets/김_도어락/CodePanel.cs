﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour {

	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// Update is called once per frame
	void Update () {
		codeText.text = codeTextValue;

		if (codeTextValue == "1234") {
			//student.isSafeOpened = true;
			codeTextValue = "9999";
		}

		if (codeTextValue.Length >= 4)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}
