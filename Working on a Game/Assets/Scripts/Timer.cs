using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timertext;
    public bool usingtime = false;
    public float timestamp;
    public GameObject DeadText;
    public AudioSource X;
    public PlayerMovement playermove;
    public int Timetocount;

    // Use this for initialization
    void Start()
    {
        Settime(Timetocount);
    }

    // Update is called once per frame
    void Update()
    {
        if (usingtime)
            setuitext();
    }

    public void Settime(float time)
    {
        if (usingtime)
            return;

        timestamp = Time.time + time;
        usingtime = true;
        
    }
    public void setuitext()
    {
    float timeleft = timestamp - Time.time;

        if (timeleft <= 0)
        {
            Death();
            return;
        }

        float hours;
        float minutes;
        float seconds;
        float miniseconds;
        Gettimevalues(timeleft, out hours, out minutes, out seconds, out miniseconds);

        if (hours > 0)
            timertext.text = string.Format("{0}:{1}", hours, minutes);
        else if (minutes > 0)
            timertext.text = string.Format("{0}:{1}", minutes, seconds);
        else 
            timertext.text = string.Format("{0}:{1}", seconds, miniseconds);
    }
    public void Death ()
    {
        timertext.text = "00:00";
        usingtime = false;
        playermove.enabled = false;
        DeadText.SetActive(true);
        X.Play();
    }
    private void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Wall")
        {
            usingtime = false;
        }
        if (collisionInfo.collider.tag == "WinLevel")
        {
            usingtime = false;
        }
    }


    public void Gettimevalues (float time, out float hours, out float minutes, out float seconds, out float miniseconds)
    {
        hours = (int)(time / 3600f);
        minutes = (int)((time - hours * 3600) / 60f);
        seconds = (int)((time - hours * 3600 - minutes * 60));
        miniseconds = (int)((time - hours * 3600 - minutes * 60 - seconds) * 100);
    }
}
