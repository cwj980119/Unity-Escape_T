using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public static AudioController Musik;

    public AudioSource BackGround; //메인 화면용 배경음악
    public AudioSource InGameBackGround; //인게임 화면용 배경음악
    public List<AudioSource> Effect = new List<AudioSource>(); //효과음

    public void ToggleMusic()
    {
        // 시작Scene이라면 BackGround에 해당되는 음악만 재생
        if(SceneManager.GetActiveScene().name=="Start Scene")
        {
            BackGround.mute = !BackGround.mute;
        }

        //그 외 Scene이라면 InGame에 해당되는 음악 재생
        else
        {
            InGameBackGround.mute = !InGameBackGround.mute;
        }
    }

    public void EffectMusic() //Effect에 해당되는 음악을 순서대로 음소거 (효과음 버튼으로 음소거)
    {
        for (int i = 0; i < Effect.Count; i++)
        {
            Effect[i].mute =! Effect[i].mute;
        }
    }

    public void EffectSoundOn(int i) //Effect에 해당되는 음악을 실행
    {
        Effect[i].Play();
    }

    public void EffectSoundOff(int i) //Effect에 해당되는 음악을 정지
    {
        Effect[i].Stop();
    }

    public void InGameSoundOn() //InGame에 해당되는 음악을 실행
    {
        InGameBackGround.Play();

        if (BackGround.mute) // 인게임에서 Mute하고 메인화면으로 나오면 On 상태 그림이 Mute로 나오는 오류 수정
        {
            InGameBackGround.mute = !InGameBackGround.mute;
        }
    }

    public void InGameSoundOff() //InGame에 해당되는 음악을 정지
    {
        InGameBackGround.Stop();
        Debug.Log("IOff");
    }

    public void MainSoundOn() //BackGround에 해당되는 음악을 실행
    {
        BackGround.Play();

        if (InGameBackGround.mute) // 시작화면에서 Mute하고 인게임으로 들어가면 On 상태 그림이 Mute로 나오는 오류 수정
        {
            BackGround.mute=!BackGround.mute;
        }
    }

    public void MainSoundOff() //BackGround에 해당되는 음악을 정지
    {
        BackGround.Stop();
        Debug.Log("Off");
    }

    // Start is called before the first frame update
    void Start()
    {
        InGameBackGround.Stop(); //초기 상태 (InGame 음악 실행 안 된 상태로 시작)
        
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
