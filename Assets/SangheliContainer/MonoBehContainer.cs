using UnityEngine;

namespace SangheliCode
{
    public class MonoBehContainer : MonoBehaviour
    {
        [SerializeField] public UIManager uiManager;
        [SerializeField] public DataContainer dataContainer;
        [SerializeField] public InputManager inputManager;
        [SerializeField] public CameraFollow cameraFollow;
        [SerializeField] public Transform parentLevel;
    }
}