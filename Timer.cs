using UnityEngine;
using UnityEngine.UI;  // Needed if using UI elements for displaying the timer


public class GameTimer : MonoBehaviour
{
    public float gameDuration = 90f;  // Duration of the game in seconds
    private float timeRemaining;
    private bool isGameOver = false;

    public Text timerText;  // Optional: UI Text element to display the timer

    void Start()
    {
        timeRemaining = gameDuration;
    }

    void Update()
    {
        if (isGameOver) return; 

        timeRemaining -= Time.deltaTime;

        if (timerText != null)
        {
            timerText.text = "Time Left: " + Mathf.Ceil(timeRemaining).ToString();
        }

        if (timeRemaining <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        isGameOver = true;
        
        Debug.Log("Time Up!");

        
    }
}

