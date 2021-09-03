using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TurnOn(){
        gameObject.SetActive(true);
    }

    public void TurnOff(){
        gameObject.SetActive(false);
    }
}
