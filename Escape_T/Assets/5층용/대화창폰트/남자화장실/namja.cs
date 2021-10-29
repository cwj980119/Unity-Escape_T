using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class namja : MonoBehaviour
{
    public Text tx;
    private string m_text = "의미 없는 텍스트니까 건드리지 마시오.";

    List<string> talkText = new List<string>();
    int i = 0;

    //
    public GameObject jungPanel;
    //

    // Start is called before the first frame update
    void Start()
    {
        // 대화창에 쓸 대화는 이 아래에만 쓰세요 

        talkText.Add("아니 거울이 왜 깨져 있지?");
        talkText.Add("여자 화장실 거울은 멀쩡하려나..");
        //talkText.Add("세번 째 문장입니다!\n화면 클릭시 대화창 꺼집니다~");

        // 대화창에 쓸 대화는 이 위에만 쓰세요 텍스트 더 쓰고 싶으면 talkText.Add("어쩌구저쩌구"); 위에 더 추가하삼
        // 멘트 추가하고 싶은 만큼 하되 하나당 3줄까지만 가능함

        talkText.Add("의미 없는 텍스트니까 건드리지 마시오.");
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
            // 모두 주석일때 - 끝나면 정상꺼짐 재시작시 마지막창
            //i = 0; // - 끝나면 다시 안녕하세요로 돌아와서 끝나질 않음
            //if (Input.GetMouseButtonDown(0))
            //{
            //i = 0;
            //jungPanel.gameObject.SetActive(false);
            //i = 0; // 한번 더 눌러야만 리셋임
            //}
            jungPanel.gameObject.SetActive(false);
            i = 0; // 한번 더 눌러야만 리셋임
            //i = 0; // - 끝나면 다시 안녕하세요로 돌아와서 끝나질 않음
        }
    }
}
