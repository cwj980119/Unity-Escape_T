using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorLock : MonoBehaviour
{
	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "8941")
		{
			GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(false);
			GameObject.Find("Canvas").transform.GetChild(4).gameObject.SetActive(true);
		}

		if (codeTextValue.Length >= 4)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}
