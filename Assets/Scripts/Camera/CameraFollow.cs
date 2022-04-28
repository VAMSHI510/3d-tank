using UnityEngine;
using Cinemachine;

public class CameraFollow : MonoBehaviour
{
    private TankView player;
    [SerializeField]
    private Camera MainCamera;
    [SerializeField]
    private CinemachineVirtualCamera TPPCam;
    public TankView Player;

   
    private void FixedUpdate()
    {
        if(player == null)
        {
            player = Player;

        }
        else
        {
            MainCamera.transform.LookAt(player.transform);
            TPPCam.m_Follow = player.transform;
            TPPCam.m_LookAt = player.transform;
        }
    }
}
