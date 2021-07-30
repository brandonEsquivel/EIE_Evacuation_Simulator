using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finnished = false;

    void Start() {
        startTime = Time.time;
    }

    void Update() {
        if(finnished)
            return;

        float t = Time.time - startTime;
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }

    public void Finnish() 
    {
        finnished = true;
        string[] words = timerText.text.Split(':');
        
        if(words[0]=="1"){
       	timerText.color = Color.yellow;
        }
        else if (words[0]=="0"){
        	timerText.color = Color.green;
        }
        else{
        	timerText.color = Color.red;
        }
    }
}
