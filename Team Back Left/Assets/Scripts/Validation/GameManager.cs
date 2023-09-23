using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    //private bool isGameOver = false;
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishLine")) {
            // isGameOver = true;
            Time.timeScale = 0;
            if (ScoreManager.score == 4)
            {
                gameOverText.text ="Mission Passed";
            }
            else
            {
                gameOverText.text ="Mission Failed";
            }
            gameOverCanvas.SetActive(true);
            

        }
    }


}
