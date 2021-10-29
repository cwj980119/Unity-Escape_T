using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door4Lock : MonoBehaviour
{
	[SerializeField]
	GameObject Door, Canvas;
	string codeTextValue = "";


	// Update is called once per frame
	void Update()
	{
		if (codeTextValue == "1946")
		{ 
			Door.SetActive(false);
			Canvas.SetActive(false);
		}

		if (codeTextValue.Length >= 4)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}
}