using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneChange : MonoBehaviour
{
    public string SceneName;
    public GameObject student;
    public GameObject camera;

    public void MMSC()
    {
        SceneManager.LoadScene(SceneName);
        Destroy(camera);
        Destroy(student);
        //GameObject.Find("student").gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        student = GameObject.Find("student");
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
