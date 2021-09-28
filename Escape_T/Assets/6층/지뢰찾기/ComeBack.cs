using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComeBack : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene(5);
    }
}
