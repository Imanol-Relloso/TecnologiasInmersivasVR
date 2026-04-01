using System;
using UnityEngine;

public class Palo3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<Beat3>())
        {
            beatHited(other.transform.GetComponent<Beat3>());
        }
    }
    private void beatHited(Beat3 beat)
    {
        beat.isHit = true;
        Destroy(beat.gameObject);
    }
}