using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCtrl : MonoBehaviour
{
    //�̹��� ��ȣ
    int imgNum = 1;

    //ī�� �޸� �̹��� ��ȣ
    int backNum = 1;

    //���µ� ī���� �Ǻ�����
    bool isOpen = false;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CheckCard();
        }
    }

    void CheckCard()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            string tag=hit.transform.tag;

            if(tag.Substring(0,4)=="card")
            {
                hit.transform.SendMessage("OpenCard", SendMessageOptions.DontRequireReceiver);
            }
        }
    }

    void ShowImage()
    {
        //ī�� �ո� �̹���
        transform.GetComponent<Renderer>().material.mainTexture = Resources.Load("card" + imgNum) as Texture2D;
    }

    void HideImage()
    {
        transform.GetComponent<Renderer>().material.mainTexture = Resources.Load("back" + imgNum) as Texture2D;
    }

}
