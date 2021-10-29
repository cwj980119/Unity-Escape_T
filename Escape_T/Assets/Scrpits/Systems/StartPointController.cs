using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPointController : MonoBehaviour
{

    public string start_point;
    private PlayerController student;
    // Start is called before the first frame update
    void Start()
    {
        student = FindObjectOfType<PlayerController>();
        if(start_point==student.currentScene){
            student.transform.position = this.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
