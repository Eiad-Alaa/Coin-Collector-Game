using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score;
    public T scoreLive;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreLive.text = score.ToString();
    }

}
