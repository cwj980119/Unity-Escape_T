using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneChange : MonoBehaviour
{
    public string SceneName;
    public GameObject student;
    public GameObject scene_camera;

    public void MMSC()
    {
        SceneManager.LoadScene(SceneName);
        Destroy(scene_camera);
        Destroy(student);
    }

    void Start()
    {
        student = GameObject.Find("student");
        scene_camera = GameObject.Find("Main Camera");
    }
}
