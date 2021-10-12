using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectAudioController : MonoBehaviour
{
    public static EffectAudioController EMusic;
    // Start is called before the first frame update

    public void TurnUpMusic()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }

    void Start()
    {
        if (EMusic == null)
        {
            DontDestroyOnLoad(this.gameObject);
            EMusic = this;
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
