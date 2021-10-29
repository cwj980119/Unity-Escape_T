using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorLock4 : MonoBehaviour
{
	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "91")
		{
			GameObject.Find("Canvas").transform.GetChild(14).gameObject.SetActive(false);
			GameObject.Find("Canvas-world").transform.GetChild(10).gameObject.SetActive(false);
		}

		if (codeTextValue.Length >= 2)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}
}
