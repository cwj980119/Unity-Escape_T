using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{
    public Text tx;
    private string m_text = "ù��° ��Ʈ���� �� �Դϴ�.";

    List<string> talkText = new List<string>();
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        talkText.Add("�ȳ��ϼ���");
        talkText.Add("�ݰ�����");
        talkText.Add("�ٽ� ������~");
        talkText.Add("�� �ȳ�~\n���� ���� ���� �ñ���!!");


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
            if (Input.GetMouseButtonDown(0))
            {
                m_text = talkText[i];
                i++;
                StartCoroutine(_typing());
            }
        }
    }
}
