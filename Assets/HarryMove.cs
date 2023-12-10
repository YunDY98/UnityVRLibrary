using UnityEngine;
using DG.Tweening;

public class HarryMove : MonoBehaviour
{
    public Transform targetPosition;
    public Transform destinationPosition;

    public GameObject targetObject;

    public Transform initPosition;

    public float duration = 10f; // 이동하는 데 걸리는 시간

    void OnTriggerEnter(Collider other)
    {
       MoveToTargetWithTween();
    }
    

   public void MoveToTargetWithTween()
    {
        // 현재 위치에서 목표 위치까지 포물선 이동
        targetObject.SetActive(true);

        targetPosition.DOMove(destinationPosition.position, duration).
        SetEase(Ease.InQuad)  
            .OnComplete(() =>targetObject.SetActive(false)); 
            
    }

    void MoveBackToStart()
    {
        // 목표 위치에서 시작 위치까지 포물선 이동
        targetPosition.DOMove(initPosition.position, duration)
            .SetEase(Ease.InQuad)  // 이동에 대한 easing 설정 (필요에 따라 변경 가능)
            .OnComplete(() => MoveToTargetWithTween());  // 이동이 완료된 후 다시 시작 위치로 이동
    }
}
