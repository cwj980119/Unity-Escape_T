using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class namja : MonoBehaviour
{
    public Text tx;
    private string m_text = "�ǹ� ���� �ؽ�Ʈ�ϱ� �ǵ帮�� ���ÿ�.";

    List<string> talkText = new List<string>();
    int i = 0;

    //
    public GameObject jungPanel;
    //

    // Start is called before the first frame update
    void Start()
    {
        // ��ȭâ�� �� ��ȭ�� �� �Ʒ����� ������ 

        talkText.Add("�ƴ� �ſ��� �� ���� ����?");
        talkText.Add("���� ȭ��� �ſ��� �����Ϸ���..");
        //talkText.Add("���� ° �����Դϴ�!\nȭ�� Ŭ���� ��ȭâ �����ϴ�~");

        // ��ȭâ�� �� ��ȭ�� �� ������ ������ �ؽ�Ʈ �� ���� ������ talkText.Add("��¼����¼��"); ���� �� �߰��ϻ�
        // ��Ʈ �߰��ϰ� ���� ��ŭ �ϵ� �ϳ��� 3�ٱ����� ������

        talkText.Add("�ǹ� ���� �ؽ�Ʈ�ϱ� �ǵ帮�� ���ÿ�.");
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
            // ��� �ּ��϶� - ������ ������ ����۽� ������â
            //i = 0; // - ������ �ٽ� �ȳ��ϼ���� ���ƿͼ� ������ ����
            //if (Input.GetMouseButtonDown(0))
            //{
            //i = 0;
            //jungPanel.gameObject.SetActive(false);
            //i = 0; // �ѹ� �� �����߸� ������
            //}
            jungPanel.gameObject.SetActive(false);
            i = 0; // �ѹ� �� �����߸� ������
            //i = 0; // - ������ �ٽ� �ȳ��ϼ���� ���ƿͼ� ������ ����
        }
    }
}
