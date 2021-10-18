using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingItems : MonoBehaviour
{
    [SerializeField]
    string NeedItem;
    public GameObject panel;

    public string getItemName(){
        return NeedItem;
    }
}

