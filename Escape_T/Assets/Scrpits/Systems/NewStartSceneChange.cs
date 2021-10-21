using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewStartSceneChange : MonoBehaviour
{
    public string SceneName;
    private GameObject player;
    private GameObject main_camera;
    public void LoadNewGame()
    {
        LoadingScene.LoadScene(SceneName);
        if(SceneName=="Start Scene")
        {
            player = GameObject.Find("student");
            main_camera = GameObject.Find("Main Camera");
            Destroy(player);
            Destroy(main_camera);
        }
    }
}
