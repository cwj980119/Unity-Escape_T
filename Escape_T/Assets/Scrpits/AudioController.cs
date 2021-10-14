using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public static AudioController Musik;

    public AudioSource BackGround;
   // public AudioSource Effect[] = new AudioSource;
    public List<AudioSource> Effect = new List<AudioSource>();

    public void ToggleMusic()
    {
        BackGround.mute = !BackGround.mute;
    }

    public void EffectMusic()
    {
        for (int i = 0; i < Effect.Count; i++)
        {
            Effect[i].mute =! Effect[i].mute;
        }
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
