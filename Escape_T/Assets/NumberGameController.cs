using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGameController : MonoBehaviour
{
    int numberA,numberB,numberC;

    void Start()
    {
        numberA = Random.Range(1,9);
        do{
            numberB = Random.Range(1,9);
        }while(numberB==numberA);
        do{
            numberC = Random.Range(1,9);
        }while(numberC==numberA&&numberC==numberB);
        Debug.Log(numberA);
        Debug.Log(numberB);
        Debug.Log(numberC);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
