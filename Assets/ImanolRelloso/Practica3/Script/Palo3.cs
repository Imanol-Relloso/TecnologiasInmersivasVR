using System;
using UnityEngine;

public class Palo3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Beat3 beat = other.GetComponent<Beat3>();
        if (beat == null) return;

        if (GameManager3.instance.gameMode != GameMode.Arrow)
        {
            beatHited(beat);
        }
        else
        {
            ArrowBeat arrow = other.GetComponent<ArrowBeat>();
            if (arrow != null)
            {
                arrow.TryHit(other);
            }
        }
    }
    private void beatHited(Beat3 beat)
    {
        beat.isHit = true;
        Destroy(beat.gameObject);
    }
}