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

    private void Awake()
    {
        if (instance == null) instance = this;

        pointsToWin = GameManager3.instance.points;
    }

    public void addPoints(bool bomb)
    {
        if (!bomb)
        {
            points++;
            if (points >= pointsToWin)
                end();
        }
        else
        {
            points--;
        }

        showPoints.updatePoints();
    }
    private void end()
    { 
        final = true;
    }
}