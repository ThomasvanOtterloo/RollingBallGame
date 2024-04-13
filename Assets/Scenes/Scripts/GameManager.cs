using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    private int count;
    public int scoreToWin;
    public UnityEvent onGameWon;
    public UnityEvent<int> onPickUpCount;

    void Start()
    {
        count = 0;
    }

    public void IncrementScore()
    {
        count++;
        onPickUpCount.Invoke(count);
        isGameWon();
    }

    public void isGameWon()
    {
        if (count >= scoreToWin)
        {
            onGameWon.Invoke();
        }
    }
}
