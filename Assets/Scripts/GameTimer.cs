using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeLimit = 300f;
    public TMP_Text timerText;
    private float timeRemaining;
    private bool running = true;

    void Start()
    {
        timeRemaining = timeLimit;
    }

    void Update()
    {
        if (!running) return;
        timeRemaining -= Time.deltaTime;
        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
            running = false;
            timerText.text = "TIME UP";
            timerText.color = Color.red;
            return;
        }
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
        if (timeRemaining <= 60)
            timerText.color = Color.red;
    }

    public void StopTimer()
    {
        running = false;
        timerText.text = "ESCAPED";
        timerText.color = Color.green;
    }
}