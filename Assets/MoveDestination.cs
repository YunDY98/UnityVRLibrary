using UnityEngine;

public class MoveDestination : MonoBehaviour
{
    // 목표 포지션 및 이동할 포지션
    public Transform targetPosition;
    public Transform destinationPosition;

    float ATimer;

    bool isPush;
    void Start()
    {
        
    }

    void update()
    {
        if(isPush)
        {
            ATimer += Time.deltaTime;
            Debug.Log("push");
        }
            Debug.Log("asd");

        if(ATimer > 3 && ATimer < 10)
        {
            Debug.Log("Moveasd");
            ATimer = 0;
            isPush = false;
            MoveToPosition();
        }
    }

    void OnTriggerEnter(Collider other)
    {
       

       MoveToPosition();

    

    }

    // void OnTriggerStay(Collider other)
    // {
    //     MoveToPosition();
    // }

    // void OnTriggerExit(Collider other)
    // {
    //     MoveToPosition();
    // }

    public void isPushF()
    {
        isPush = true;

    }

    // 원하는 포지션으로 이동시키는 함수
    public void MoveToPosition()
    {

        
        targetPosition.position = destinationPosition.position;
          
        
        
       

        
    
       
    }
}
