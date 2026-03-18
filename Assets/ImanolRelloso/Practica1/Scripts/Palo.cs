using System;
using UnityEngine;

public class Palo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);

        if (other.transform.GetComponent<Beat>())
        {
            Beat(other.transform);
        }
    }
    private void Beat(Transform beat)
    {
        BeatManager.instance.addPoints();
        Destroy(beat);
    }
}