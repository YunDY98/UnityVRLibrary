using UnityEngine;
using DG.Tweening;

public class OpenDoor : MonoBehaviour
{
    public Vector3 openRotation = new Vector3(0, -90, 0); // 열린 상태의 회전 각도
    public float animationDuration = 100.0f; // 애니메이션의 지속 시간

    private Quaternion initialRotation;

    public AudioClip soundClip; // Inspector 창에서 할당할 소리 파일
    private AudioSource audioSource;

   // public Transform targetPosition;
   // public Transform destinationPosition;
  
    void Start()
    {
        
    }

    public void PushButton()
    {
        // AudioSource 컴포넌트 가져오기
        audioSource = gameObject.AddComponent<AudioSource>();

        // 소리 파일 설정
        audioSource.clip = soundClip;
        
        audioSource.Play();

        // 초기 회전 각도 저장
        initialRotation = transform.rotation;

        // 문이 열리는 애니메이션
        transform.DORotate(openRotation, animationDuration)
            .SetEase(Ease.OutCubic) // 이징 함수 설정
            .OnComplete(() =>
            {
               // targetPosition.position = destinationPosition.position;
                // 3초 후에 문이 닫히는 애니메이션
                transform.DORotate(initialRotation.eulerAngles, 7f)
                    .SetEase(Ease.InCubic);
            });
    }
}
