using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float scoreCount;

    public Text text;
    void Start()
    {
        scoreCount = 0;
    }

    void Update()
    {
        text.text = scoreCount.ToString();
    }
}
