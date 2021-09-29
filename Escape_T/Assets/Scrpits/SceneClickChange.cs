using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneClickChange : MonoBehaviour
{
    public string nextScene;

    public void SceneChange()
    {
        SceneManager.LoadScene(nextScene);
    }
}
