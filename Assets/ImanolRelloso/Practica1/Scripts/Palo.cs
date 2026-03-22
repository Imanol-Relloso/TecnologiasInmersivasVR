using System;
using UnityEngine;

public class Palo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<Beat>())
        {
            beatHited(other.transform.GetComponent<Beat>());
        }
    }
    private void beatHited(Beat beat)
    {
        beat.isHit = true;
        Destroy(beat.gameObject);
    }
}