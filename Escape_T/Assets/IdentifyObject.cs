using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endButton : MonoBehaviour
{
    private bool state;
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
            if (hit.collider != null)
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
