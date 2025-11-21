using UnityEngine;
using Unity.Cinemachine;

public class CameraRegister : MonoBehaviour
{

    private void Awake()
    {
        CameraManager.Register(GetComponent<CinemachineCamera>());
    }

    private void OnDestroy()
    {
        CameraManager.Unregister(GetComponent<CinemachineCamera>());
    }
}
