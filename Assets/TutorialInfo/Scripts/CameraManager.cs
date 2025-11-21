using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;



public class CameraManager : MonoBehaviour
{
    static List<CinemachineCamera> cameras = new List<CinemachineCamera>();

    public static CinemachineCamera ActiveCamera = null;

    public CinemachineCamera mainCamera;
    public CinemachineCamera camera1;
    public CinemachineCamera camera2;

    public static bool IsActiveCamera(CinemachineCamera camera)
    {
        return camera == ActiveCamera;
    }

    public static void SwtichCamera(CinemachineCamera newCamera)
    {
        if (!cameras.Contains(newCamera)) return;

        ActiveCamera = newCamera;

        foreach (CinemachineCamera cam in cameras)
        {
            cam.gameObject.SetActive(cam == newCamera);
        }
    }

    public static void Register(CinemachineCamera camera)
    {
        cameras.Add(camera);
    }

    public static void Unregister(CinemachineCamera camera)
    {
        cameras.Remove(camera);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            SwtichCamera(mainCamera);
        }


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwtichCamera(camera1);
        }


        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwtichCamera(camera2);
        }

    }

}
