using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class BeatManager3 : MonoBehaviour
{
    public static BeatManager3 instance;

    public int points;

    public int pointsToWin;

    [SerializeField] private ShowPoints3 showPoints;

    public bool final = false;
    public bool win = false;

    private float duration;
    private float timePlayed;

    private void Awake()
    {
        if (instance == null) instance = this;

        pointsToWin = GameManager3.instance.points;
        duration = GameManager3.instance.song.length;
        timePlayed = 0;
    }

    private void Update()
    {
        timePlayed += Time.deltaTime;
        if (duration < timePlayed)
        {
            end(false);
            showPoints.updatePoints();
        }
    }

    public void addPoints(bool bomb)
    {
        if (!bomb)
        {
            points++;
            if (points >= pointsToWin)
                end(true);
        }
        else
        {
            points--;
        }

        showPoints.updatePoints();
    }
    private void end(bool w)
    { 
        final = true;
        win = w;
    }
}