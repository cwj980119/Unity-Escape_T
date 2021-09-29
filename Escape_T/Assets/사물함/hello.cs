using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hello : MonoBehaviour
{

	[SerializeField]
	Text codeText;
	string codeTextValue = "";

	// 테스트
	public Image Openlock;

	// 수정
	[SerializeField]
	Text Htext;
	string HtextValue = "";
	//

	void Start()
	{
		Openlock.enabled = true;

	}

	//수정
	void Check_Htext()
    {

    }
	//

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue;

		if (codeTextValue == "1234")
		{
			//student.isSafeOpened = true;
			// 그냥 내가 해본거 codeTextValue = "9999";

			Openlock.enabled = false;

		}

		if (codeTextValue.Length >= 4)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}


/*   int tenConvertTwo(int n)
{
    int result = 0;
    for(int i=0;n>0;i*=10)
    {
        int binary = n % 2;
        result += binary * i;
        n /= 2;
    }
    return result;
}

int twoConvertTen(int n)
{
    int result = 0;
    int mul = 1;
    while(num>0)
    {
        if(n%2)
        { 
            result += mul; 
        }
        mul *= 2;
        num /= 10;
    }
    return result;
}
*/
