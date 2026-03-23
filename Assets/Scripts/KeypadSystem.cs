using UnityEngine;

public class KeypadSystem : MonoBehaviour
{
    public string correctCode = "123";
    private string currentInput = "";

    public GameObject puzzle3Object;
    public Renderer displayRenderer;

    public AudioSource audioSource;
    public AudioClip successSound;
    public AudioClip failSound;

    public void PressButton(string value)
    {
        currentInput += value;

        if (currentInput.Length >= correctCode.Length)
        {
            if (currentInput == correctCode)
                Unlock();
            else
                ResetInput();
        }
    }

    void Unlock()
    {
        if (puzzle3Object != null)
            puzzle3Object.SetActive(true);

        if (displayRenderer != null)
            displayRenderer.material.color = Color.green;

        if (audioSource != null && successSound != null)
            audioSource.PlayOneShot(successSound);

        Debug.Log("Correct code entered.");
    }

    void ResetInput()
    {
        currentInput = "";

        if (displayRenderer != null)
            displayRenderer.material.color = Color.red;

        if (audioSource != null && failSound != null)
            audioSource.PlayOneShot(failSound);

        Debug.Log("Wrong code.");
    }
}