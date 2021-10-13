using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewStartSceneChange : MonoBehaviour
{
    public string SceneName;
    public void LoadNewGame()
    {
        LoadingScene.LoadScene(SceneName);
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
