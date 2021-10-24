using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour {

	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// 테스트
	public Image Openlock;
	public GameObject panel;


	void Start()
    {
		Openlock.enabled = false;
		//GameObject.Find("Canvas_도어락").transform.GetChild(1).gameObject.SetActive(false);
		panel.gameObject.SetActive(false);
	}

	//테스트

	// Update is called once per frame
	void Update () {
		codeText.text = codeTextValue;

		if (codeTextValue == "32112") {
			//student.isSafeOpened = true;
			// 그냥 내가 해본거 codeTextValue = "9999";
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
