using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneClickChange : MonoBehaviour
{
    public string nextScene;
    private PlayerController student;

    void Start()
    {
        student = FindObjectOfType<PlayerController>();
        
    }
    public void SceneChange()
    {
        student.currentScene = nextScene;
        SceneManager.LoadScene(nextScene);
    }
}
