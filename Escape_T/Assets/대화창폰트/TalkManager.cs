using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{
    public Text tx;
    private string m_text = "박현서 늦잠 잤대여 에베베베";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(2f);

        for (int i = 0; i <= m_text.Length; i++) 
        {
            tx.text = m_text.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }
    }
}
