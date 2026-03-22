using UnityEngine;
using UnityEngine.UIElements;

public class BeatManager : MonoBehaviour
{
    public static BeatManager instance;

    public int points;

    [SerializeField] private ShowPoints showPoints;

    public bool final = false;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    public void addPoints()
    {
        points++;
        if (points >= 20)
            end();

        showPoints.updatePoints();
    }
    private void end()
    { 
        final = true;
    }
}