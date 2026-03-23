using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class DoorController : MonoBehaviour
{
    public XRSocketInteractor keySocket;
    public Transform exitDoor;
    public Vector3 openOffset = new Vector3(0f, 2.5f, 0f);
    public GameObject uiMessage;
    public AudioSource audioSource;
    public AudioClip doorSound;
    public GameTimer gameTimer;

    private Vector3 closedPosition;
    private Vector3 targetPosition;
    private bool opened = false;
    private bool isMoving = false;
    public float doorSpeed = 1.5f;

    void Start()
    {
        if (exitDoor != null)
        {
            closedPosition = exitDoor.position;
            targetPosition = closedPosition;
        }

        if (uiMessage != null)
            uiMessage.SetActive(false);
    }

    void Update()
    {
        if (!opened && keySocket != null && keySocket.hasSelection)
            OpenDoor();

        if (isMoving && exitDoor != null)
        {
            exitDoor.position = Vector3.Lerp(
                exitDoor.position,
                targetPosition,
                Time.deltaTime * doorSpeed
            );

            if (Vector3.Distance(exitDoor.position, targetPosition) < 0.01f)
            {
                exitDoor.position = targetPosition;
                isMoving = false;

                if (uiMessage != null)
                    uiMessage.SetActive(true);
            }
        }
    }

    void OpenDoor()
    {
        opened = true;
        targetPosition = closedPosition + openOffset;
        isMoving = true;

        if (audioSource != null && doorSound != null)
            audioSource.PlayOneShot(doorSound);

        if (gameTimer != null)
            gameTimer.StopTimer();
        Debug.Log("Door opening.");
    }
}