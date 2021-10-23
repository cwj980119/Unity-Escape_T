using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public static AudioController Musik;

    public AudioSource BackGround; //���� ȭ��� �������
    public AudioSource InGameBackGround; //�ΰ��� ȭ��� �������
    public List<AudioSource> Effect = new List<AudioSource>(); //ȿ����

    public void ToggleMusic()
    {
        // ����Scene�̶�� BackGround�� �ش�Ǵ� ���Ǹ� ���
        if(SceneManager.GetActiveScene().name=="Start Scene")
        {
            BackGround.mute = !BackGround.mute;
        }

        //�� �� Scene�̶�� InGame�� �ش�Ǵ� ���� ���
        else
        {
            InGameBackGround.mute = !InGameBackGround.mute;
        }
    }

    public void EffectMusic() //Effect�� �ش�Ǵ� ������ ������� ���Ұ� (ȿ���� ��ư���� ���Ұ�)
    {
        for (int i = 0; i < Effect.Count; i++)
        {
            Effect[i].mute =! Effect[i].mute;
        }
    }

    public void EffectSoundOn(int i) //Effect�� �ش�Ǵ� ������ ����
    {
        Effect[i].Play();
    }

    public void EffectSoundOff(int i) //Effect�� �ش�Ǵ� ������ ����
    {
        Effect[i].Stop();
    }

    public void InGameSoundOn() //InGame�� �ش�Ǵ� ������ ����
    {
        InGameBackGround.Play();

        if (BackGround.mute) // �ΰ��ӿ��� Mute�ϰ� ����ȭ������ ������ On ���� �׸��� Mute�� ������ ���� ����
        {
            InGameBackGround.mute = !InGameBackGround.mute;
        }
    }

    public void InGameSoundOff() //InGame�� �ش�Ǵ� ������ ����
    {
        InGameBackGround.Stop();
        Debug.Log("IOff");
    }

    public void MainSoundOn() //BackGround�� �ش�Ǵ� ������ ����
    {
        BackGround.Play();

        if (InGameBackGround.mute) // ����ȭ�鿡�� Mute�ϰ� �ΰ������� ���� On ���� �׸��� Mute�� ������ ���� ����
        {
            BackGround.mute=!BackGround.mute;
        }
    }

    public void MainSoundOff() //BackGround�� �ش�Ǵ� ������ ����
    {
        BackGround.Stop();
        Debug.Log("Off");
    }

    // Start is called before the first frame update
    void Start()
    {
        InGameBackGround.Stop(); //�ʱ� ���� (InGame ���� ���� �� �� ���·� ����)
        
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
