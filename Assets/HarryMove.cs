using UnityEngine;
using DG.Tweening;

public class HarryMove : MonoBehaviour
{
    public Transform targetPosition;
    public Transform destinationPosition;

    public GameObject targetObject;

    

    private float duration = 3f; // 이동하는 데 걸리는 시간

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

 
}
