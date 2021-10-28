using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkEndSceneChange : MonoBehaviour
{
    int clickNum = 0;
    private PlayerController student;
    public string nextScene;
    
    void Start()
    {
        student = FindObjectOfType<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            clickNum++;
        }
        if(clickNum>2){
            student.currentScene = nextScene;
            LoadingScene.LoadScene(nextScene);
            clickNum = 0;
        }
    }
}
