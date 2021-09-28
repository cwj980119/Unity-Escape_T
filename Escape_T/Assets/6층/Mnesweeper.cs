using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mnesweeper : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene(4);
    }
}
