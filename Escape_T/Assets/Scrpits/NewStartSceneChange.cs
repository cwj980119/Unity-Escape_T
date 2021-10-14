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
        //GameObject.Find("student").gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
