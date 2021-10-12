using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public static AudioController Musik;
    public void TurnMusic()
    {
        AudioListener.volume = AudioListener.volume == 0?1:0;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (Musik == null)
        {
            DontDestroyOnLoad(this.gameObject);
            Musik = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
