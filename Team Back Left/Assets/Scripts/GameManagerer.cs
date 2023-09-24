using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerer : MonoBehaviour
{
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene"); // Load the "GameOverScene" when the game is over
    }
}
