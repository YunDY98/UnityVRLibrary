using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScean : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // 트리거에 다른 Collider가 진입했을 때 호출
        
            Debug.Log("trigger Scene");
            // 씬 전환
            SceneManager.LoadScene("SampleScene");
        
    }
}
