using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour {

	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	public Image Openlock;
	public GameObject panel;

	void Start()
    {
		Openlock.enabled = false;
		panel.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		codeText.text = codeTextValue;

		if (codeTextValue == "32112") {
			Openlock.enabled = true;
			GameObject.Find("Canvas_도어락").transform.GetChild(1).gameObject.SetActive(true);
			panel.gameObject.SetActive(true);
		}

		if (codeTextValue.Length >= 5)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}
}
