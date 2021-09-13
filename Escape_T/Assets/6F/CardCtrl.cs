using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCtrl : MonoBehaviour
{
    //이미지 번호
    int imgNum = 1;

    //카드 뒷면 이미지 번호
    int backNum = 1;

    //오픈된 카드의 판별여부
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
        //카드 앞면 이미지
        transform.GetComponent<Renderer>().material.mainTexture = Resources.Load("card" + imgNum) as Texture2D;
    }

    void HideImage()
    {
        transform.GetComponent<Renderer>().material.mainTexture = Resources.Load("back" + imgNum) as Texture2D;
    }

}
