using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotappear : MonoBehaviour
{
    private bool state;
    public GameObject Target;

    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (state == true)
            {
                Target.SetActive(false);
                state = false;
            }
            else
            {
                Target.SetActive(true);
                state = true;
            }
        }
    }
}
