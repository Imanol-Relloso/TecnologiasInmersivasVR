using UnityEngine;

public class BeatSpawner2 : MonoBehaviour
{
    private Transform[] spawnPoints;

    [SerializeField] private GameObject beat;

    [SerializeField] private float spawnTime;
    private float waitedTime;

    [SerializeField] private float bombProb;

    void Start()
    {
        spawnPoints = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            spawnPoints[i] = transform.GetChild(i);
        }
    }
    private void Update()
    {
        if (BeatManager2.instance.final) return;

        if (spawnTime <= waitedTime)
        {
            spawnBeat();
            waitedTime = 0;
        }
        waitedTime += Time.deltaTime;
    }
    private void spawnBeat()
    {
        GameObject b = Instantiate(beat, spawnPoints[Random.Range(0,spawnPoints.Length)]);

        if (!GameManager.instance.easy)
        {
            if (Random.Range(0, 100) < bombProb)
                b.GetComponent<Beat2>().bomb = true;
            else
                b.GetComponent<Beat2>().bomb = false;
        }
    }
}
