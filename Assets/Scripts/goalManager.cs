using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class goalManager : MonoBehaviour
{
    public static int leftPlayerScore;
    public static int rightPlayerScore;
    private TMP_Text scoreboardText;

    // Start is called before the first frame update
    void Start()
    {
        scoreboardText = GetComponent<TMP_Text>();
        leftPlayerScore = 0;
        rightPlayerScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreboardText.text = leftPlayerScore + " - " + rightPlayerScore;
        if (goalManager.leftPlayerScore == 3 || goalManager.rightPlayerScore == 3)
        {
            SceneManager.LoadScene(2);
        }
    }
}
