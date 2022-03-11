using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timeCounter;

     GameObject _endScreen;
     GameObject _expScreen;

    public GameObject CanvasMain;
    public Text text;

    void Start()
    {
        timeCounter = 60f;
        CanvasMain = GameObject.FindGameObjectWithTag("Canvas");
        _endScreen = CanvasMain.transform.GetChild(6).gameObject;
        _expScreen = CanvasMain.transform.GetChild(5).gameObject;
    }

    void Update()
    {
        timeCounter -= Time.deltaTime;
        text.text = ((int)timeCounter).ToString();
        //text.text = "" + (int)timeCounter;

        if (timeCounter <= 0)
        {
            _endScreen.SetActive(true);
            _expScreen.SetActive(false);
            Invoke("FreezeTime", .5f);
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void FreezeTime()
    {
        Time.timeScale = 0;
    }
}
