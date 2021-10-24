using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListTalk : MonoBehaviour
{
    public Text[] textlist;

    public Text tx;
    private string m_text = "";

    List<string> talkText = new List<string>();
    int i = 0;

    //
    public GameObject jungPanel;
    //

    // Start is called before the first frame update
    void Start()
    {

        for(int i=0;i<textlist.Length;i++){
            talkText.Add(textlist[i].text);
        }

        talkText.Add("");
        StartCoroutine(_typing());
    }

    IEnumerator _typing()
    {
        //yield return new WaitForSeconds(2f);

        for (int i = 0; i <= m_text.Length; i++)
        {
            tx.text = m_text.Substring(0, i);

            yield return new WaitForSeconds(0.1f);
        }
    }

    void Update()
    {
        if (i < talkText.Count)
        {
            //
            if (i == 0)
            {
                m_text = talkText[i];
                i++;
                StartCoroutine(_typing());
            }
            //
            if (Input.GetMouseButtonDown(0))
            {
                m_text = talkText[i];
                i++;
                StartCoroutine(_typing());
            }
        }

        else
        {

            //if (Input.GetMouseButtonDown(0))
            //{
            //i = 0;
            //jungPanel.gameObject.SetActive(false);
            //}
            jungPanel.gameObject.SetActive(false);
            i = 0; 
        }
    }
}
