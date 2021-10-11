using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneChange : MonoBehaviour
{
    public string SceneName;

    public void MMSC()
    {
        SceneManager.LoadScene(SceneName);
        //GameObject.Find("student").gameObject.SetActive(false);
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
