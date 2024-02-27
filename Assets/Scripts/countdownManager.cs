using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class countdownManager : MonoBehaviour
{
    private int countdownNum = 3;
    private static TMP_Text countdownText = null;
    // Start is called before the first frame update
    void Start()
    {
        countdownText = GetComponent<TMP_Text>();
        countdownText.text = countdownNum.ToString();
        StartCoroutine(CountDown(countdownNum));


    }
    public static IEnumerator CountDown(int seconds)
    {
        int count = seconds;
        
        while (count > 0)
        {
            countdownText.text = count.ToString();

            yield return new WaitForSeconds(1);
            count--;
        }
        // count down is finished...    
        countdownText.text = "";;
        ballManager.startGame();
   }
}
