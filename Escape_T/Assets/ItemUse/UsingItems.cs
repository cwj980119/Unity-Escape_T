using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingItems : MonoBehaviour
{
    [SerializeField]
    string NeedItem;

    public string getItemName(){
        return NeedItem;
    }
}
