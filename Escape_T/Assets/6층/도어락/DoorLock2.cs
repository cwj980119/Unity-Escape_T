using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorLock2 : MonoBehaviour
{
	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "96")
		{
			GameObject.Find("Canvas").transform.GetChild(12).gameObject.SetActive(false);
			GameObject.Find("ComputerRoom").transform.GetChild(0).gameObject.SetActive(false);
		}

		if (codeTextValue.Length >= 2)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}
}
