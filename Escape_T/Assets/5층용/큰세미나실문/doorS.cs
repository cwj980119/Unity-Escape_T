using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doorS : MonoBehaviour
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

		if (codeTextValue == "1985")
		{
			//student.isSafeOpened = true;
			// �׳� ���� �غ��� codeTextValue = "9999";
			//Openlock.enabled = true;
			//GameObject(prefab).SetActive(false);
			GameObject.Find("Canvas_worldū���̳��ǹ�").transform.GetChild(0).gameObject.SetActive(false);
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
