using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateLock : MonoBehaviour
{
    [SerializeField]
	Text codeText;
    [SerializeField]
    int answer;
	int codeTextValue = 0;

	// Update is called once per frame
	void Update()
	{
		codeText.text = codeTextValue.ToString();
	}

	public void UpDigit()
	{
        if(codeTextValue<9){
		    codeTextValue++;
        }
        else{
            codeTextValue=0;
        }
	}

    public void DownDigit(){
        if(codeTextValue>0){
            codeTextValue--;
        }
        else{
            codeTextValue=9;
        }
    }

    public bool Check(){
        if(codeTextValue==answer){
            return true;
        }
        else {
            return false;
        }
    }
}
