using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string nextScene;
    private PlayerController student;
    // Start is called before the first frame update
    void Start()
    {
        student = FindObjectOfType<PlayerController>();
        
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "student")
        {
            student.currentScene = nextScene;
            student.StopMove();
            //SceneManager.LoadScene(nextScene);
            LoadingScene.LoadScene(nextScene);
        }
    }
}
