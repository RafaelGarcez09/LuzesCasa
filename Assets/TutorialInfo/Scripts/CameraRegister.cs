using UnityEngine;
using Unity.Cinemachine;

public class CameraRegister : MonoBehaviour
{
    private void OEnable()
    {
        CameraManager.Register(GetComponent<CinemachineCamera>());
    }
    private void ODisable()
    {
        CameraManager.Unregister(GetComponent<CinemachineCamera>());
    }
}
