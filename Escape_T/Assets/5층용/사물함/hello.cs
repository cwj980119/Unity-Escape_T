using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hello : MonoBehaviour
{

	[SerializeField]
	Text codeText;
	string codeTextValue;//= "";

	// �׽�Ʈ
	public Image Openlock;

	// ����
	[SerializeField]
	Text Htext;
	string HtextValue;// = "";

	[SerializeField]
	Text Stext;
	string StextValue;// = "";

	[SerializeField]
	Text Ttext;
	string TtextValue;// = "";

	[SerializeField]
	Text Ftext;
	string FtextValue;// = "";
	//

	void Start()
	{
		Openlock.enabled = true;

	}

	//����
	string tenConvertTwo(string aa)
	{
		int n = int.Parse(aa);
		//int n=32;
		int a = n / 10;
		int b = n % 10;

		int ra = 1;
		int rb = 1;

		for(int i=0;i<a;i++)
        {
			ra *= 2;
        }

		for (int i = 0; i < b; i++)
		{
			rb *= 2;
		}

		int rr = ra + rb;

		int [] binary = new int[20];
        //binary[20] ={ 0,};
		int position = 0;
		while (true)
		{
			binary[position] = rr % 2;    // 2�� �������� �� �������� �迭�� ����
			rr = rr / 2;             // 2�� ���� ���� ����

			position++;    // �ڸ��� ����

			if (rr == 0)    // ���� 0�� �Ǹ� �ݺ��� ����
				break;
		}

		string abc= "";
				   // �迭�� ��Ҹ� �������� ���
		for (int i = position - 1; i >= 0; i--)
		{
			abc += binary[i];
		}

		//
		return abc;
	}

	string ConvertTwo(string aa)
    {
		int n = int.Parse(aa);
		int a = n / 100;
		int b = (n % 100) / 10;
		int c = n % 10;

		int ra = 1;
		int rb = 1;
		int rc = 1;

		for (int i = 0; i < a; i++)
		{
			ra *= 2;
		}

		for (int i = 0; i < b; i++)
		{
			rb *= 2;
		}
		
		for (int i = 0; i < c; i++)
		{
			rc *= 2;
		}


		int rr = ra + rb + rc;

		int[] binary = new int[20];
		//binary[20] ={ 0,};
		int position = 0;
		while (true)
		{
			binary[position] = rr % 2;    // 2�� �������� �� �������� �迭�� ����
			rr = rr / 2;             // 2�� ���� ���� ����

			position++;    // �ڸ��� ����

			if (rr == 0)    // ���� 0�� �Ǹ� �ݺ��� ����
				break;
		}

		string abc= "";
				   // �迭�� ��Ҹ� �������� ���
		for (int i = position - 1; i >= 0; i--)
		{
			abc += binary[i];
		}

		//
		return abc;
	}

	//
	int i = 0;
	// Update is called once per frame
	void Update()
	{
		if (i == 0)
		{
			codeText.text = codeTextValue;

			if (codeTextValue == "18")
			{
				//student.isSafeOpened = true;
				// �׳� ���� �غ��� codeTextValue = "9999";
				Htext.text = "�й� �� ���� 2�� �Է� : C011018\n18 = 2^? + 2^?\n?�� �� ���ڸ� ������� �Է�";
				i++;
				//Openlock.enabled = false;

			}

			if (codeTextValue.Length >= 2)
				codeTextValue = "";
		}
		if(i==1)
        {
			codeText.text = codeTextValue;
			int n = int.Parse(codeTextValue);
			int a = n / 10;
			int b = n % 10;

			Stext.text = "2^"+a.ToString()+" + 2^"+b.ToString()+" = "+tenConvertTwo(codeTextValue)+"\n�ùٸ� 2���� ��й�ȣ�� �ƴմϴ�.\n�ٽ� �Է��ϼ���.";



			if (codeTextValue == "41")
			{
				Stext.text = "10010\n��й�ȣ�� �½��ϴ�.";
				i++;
			}

			else if (codeTextValue.Length >= 2)
			{
				//Stext.text = "Ʋ������ �ٽ� �Է��ϼ���";
				codeTextValue = "";
			}
		}
		if(i==2)
        {
			codeText.text = codeTextValue;

			if (codeTextValue == "22")
			{
				//student.isSafeOpened = true;
				// �׳� ���� �غ��� codeTextValue = "9999";
				Ttext.text = "�й� �� ���� 2�� �Է� : C011022\n22 = 2^? + 2^? + 2^?\n?�� �� ���ڸ� ������� �Է�";
				i++;
				//Openlock.enabled = false;

			}

			if (codeTextValue.Length >= 2)
				codeTextValue = "";
		}
		if(i==3)
        {
			codeText.text = codeTextValue;
			int n = int.Parse(codeTextValue);
			int a = n / 100;
			int b = (n % 100) / 10;
			int c = n % 10;

			Ftext.text = "2^" + a.ToString() + " + 2^" + b.ToString() + " + 2^" + c.ToString() + " = " + ConvertTwo(codeTextValue) + "\n�ùٸ� 2���� ��й�ȣ�� �ƴմϴ�.\n�ٽ� �Է��ϼ���.";



			if (codeTextValue == "421")
			{
				Ftext.text = "10110\n��й�ȣ�� �½��ϴ�.\n�繰���� ���Ƚ��ϴ�\nâ�� ��������.";
				i++;
				Openlock.enabled = false;
			}

			else if (codeTextValue.Length >= 3)
			{
				//Stext.text = "Ʋ������ �ٽ� �Է��ϼ���";
				codeTextValue = "";
			}
		}

		if(i==4)
        {

        }
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}

/*
int tenConvertTwo(int n)
{
	int a = n / 10;
	int b = n % 10;

	int rr = Math.Pow(2, a) + Math.Pow(2, b);
    int result = 0;
    for(int i=0;rr>0;i*=10)
    {
        int binary = rr % 2;
        result += binary * i;
        rr /= 2;
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