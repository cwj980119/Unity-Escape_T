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

    public void TurnOffMusic()
    {
        BackGround.Pause();
    }

    public void TurnOnMusic()
    {
        BackGround.Play();
    }

    public void TurnEffectOnMusic()
    {
        for (int i=0; i<Effect.Count; i++)
        {
            Effect[i].Play();
        }
    }

    public void TurnEffectOffMusic()
    {
        for (int i = 0; i < Effect.Count; i++)
        {
            Effect[i].Pause();
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
