using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class MovementController : MonoBehaviour
{
    private XRController xrController;

    void Start()
    {
        xrController = GetComponent<XRController>();
        if (xrController == null)
        {
            Debug.LogError("XRController component not found on GameObject.");
        }
    }

    void Update()
    {
        if (xrController.inputDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceVelocity, out Vector3 velocity))
        {
            // 속도를 0으로 만들기
            velocity = Vector3.zero;

            // 이동 로직을 여기에 추가
            // 예: transform.Translate(velocity * Time.deltaTime);
        }
    }
}
