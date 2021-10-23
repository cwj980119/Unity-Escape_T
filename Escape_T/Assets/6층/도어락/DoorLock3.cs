using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorLock3 : MonoBehaviour
{
	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "45")
		{
			GameObject.Find("Canvas").transform.GetChild(13).gameObject.SetActive(false);
			GameObject.Find("MultiMediaRoom").transform.GetChild(0).gameObject.SetActive(false);
		}

		if (codeTextValue.Length >= 2)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}
}
