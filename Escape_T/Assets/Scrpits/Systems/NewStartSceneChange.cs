using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewStartSceneChange : MonoBehaviour
{
    public string SceneName;
    private GameObject player;
    public void LoadNewGame()
    {
        LoadingScene.LoadScene(SceneName);
        if(SceneName=="Start Scene")
        {
            player = GameObject.Find("student");
            Destroy(player);
        }
    }
}
