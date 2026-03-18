using UnityEngine;
using UnityEngine.UIElements;

public class BeatManager : MonoBehaviour
{
    public static BeatManager instance;

    public int points;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    public void addPoints()
    {
        points++;
    }
}