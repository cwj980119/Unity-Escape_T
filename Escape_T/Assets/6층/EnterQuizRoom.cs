using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterQuizRoom : MonoBehaviour
{
    public string nextScene;
    public GameObject stageNumObject1;
    public GameObject stageNumObject2;

    public void call()
    {
        SceneManager.LoadScene(nextScene);
        DontDestroyOnLoad(stageNumObject1);
        DontDestroyOnLoad(stageNumObject2);
    }
}
