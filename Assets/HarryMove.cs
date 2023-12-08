using UnityEngine;
using DG.Tweening;

public class HarryMove : MonoBehaviour
{
    public Transform targetPosition;
    public Transform destinationPosition;

    public float duration = 2f; // 이동하는 데 걸리는 시간

    

   public void MoveToTargetWithTween()
    {
        // 현재 위치에서 목표 위치까지 포물선 이동
        targetPosition.DOMove(destinationPosition.position, duration);
            
    }

    void MoveBackToStart()
    {
        // 목표 위치에서 시작 위치까지 포물선 이동
        transform.DOMove(destinationPosition.position, duration)
            .SetEase(Ease.InQuad)  // 이동에 대한 easing 설정 (필요에 따라 변경 가능)
            .OnComplete(() => MoveToTargetWithTween());  // 이동이 완료된 후 다시 시작 위치로 이동
    }
}
