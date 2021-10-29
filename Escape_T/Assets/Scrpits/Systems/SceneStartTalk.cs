using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStartTalk : MonoBehaviour
{
    public GameObject talk;

    private void Start() {
        talk.SetActive(true);
    }
}
