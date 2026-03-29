using System;
using UnityEngine;

public class Palo2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<Beat2>())
        {
            beatHited(other.transform.GetComponent<Beat2>());
        }
    }
    private void beatHited(Beat2 beat)
    {
        beat.isHit = true;
        Destroy(beat.gameObject);
    }
}