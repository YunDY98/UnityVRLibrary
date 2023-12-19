using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnOff : MonoBehaviour
{
    public AudioClip soundClip; // Inspector 창에서 할당할 소리 파일
    private AudioSource audioSource;

    bool isused = true;
    // Start is called before the first frame update

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        // 소리 파일 설정
        audioSource.clip = soundClip;

        audioSource.volume = 0.1f;
        audioSource.loop = true;
       
    }
    
    public void OnOff()
    {
        
        if(isused)
        {
            
            
            audioSource.Play();

            isused = false;

        }
        else
        {
            audioSource.Stop();
            isused = true;
        }
        

    }
}
