using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class DoorController : MonoBehaviour
{
    public XRSocketInteractor keySocket;
    public Transform exitDoor;
    public Vector3 openOffset = new Vector3(1.5f, 0f, 0f);
    public GameObject uiMessage;

    private Vector3 closedPosition;
    private bool opened = false;

    void Start()
    {
        if (exitDoor != null)
            closedPosition = exitDoor.position;
    }

    void Update()
    {
        if (!opened && keySocket != null && keySocket.hasSelection)
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        opened = true;

        if (exitDoor != null)
            exitDoor.position = closedPosition + openOffset;

        if (uiMessage != null)
            uiMessage.SetActive(true);

        Debug.Log("Exit door opened.");
    }
}