using UnityEngine;

public class Beat : MonoBehaviour
{
    private void Start()
    {
        //transform.GetComponent<Rigidbody>().AddForce(Vector3.up);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);

        if (other.transform.GetComponent<Palo>())
        {
            destroy(other.transform);
        }
    }
    private void destroy(Transform beat)
    {
        BeatManager.instance.addPoints();
        Destroy(beat);
    }
}
