using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text countText;
    public TMP_Text winText;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void setCountText(int count)
    {
        countText.text = "Count: " + count.ToString();//getScore
    }

    public void setWinText()
    {
        winText.text = "You Win!";
    }
}
