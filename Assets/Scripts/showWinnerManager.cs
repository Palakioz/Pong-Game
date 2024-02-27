using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class showWinnerManager : MonoBehaviour
{
    public static TMP_Text winnerText;

    // Start is called before the first frame update
    void Awake()
    {
        winnerText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goalManager.leftPlayerScore == 3 || goalManager.rightPlayerScore == 3)
        {
            endGame();
        }
    }

    private void endGame()
    {
        if (goalManager.leftPlayerScore == 3)
        {
            showWinnerManager.winnerText.text = "Player 1 Wins!";
        }
        else if (goalManager.rightPlayerScore == 3)
        {
            showWinnerManager.winnerText.text = "Player 2 Wins!";
        }
    }
}
