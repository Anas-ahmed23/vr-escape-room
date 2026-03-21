using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Puzzle1Manager : MonoBehaviour
{
    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;
    public XRSocketInteractor socket3;

    public GameObject powerLight;

    void Update()
    {
        if (socket1.hasSelection &&
            socket2.hasSelection &&
            socket3.hasSelection)
        {
            ActivatePower();
        }
    }

    void ActivatePower()
    {
        powerLight.SetActive(true);
    }
}