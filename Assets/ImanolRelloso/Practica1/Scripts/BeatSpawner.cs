using UnityEngine;

public class BeatSpawner : MonoBehaviour
{
    private Transform[] spawnPoints;

    [SerializeField] private GameObject beat;

    [SerializeField] private float spawnTime;
    private float waitedTime;
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
        if (BeatManager.instance.final) return;

        if (spawnTime <= waitedTime)
        {
            spawnBeat();
            waitedTime = 0;
        }
        waitedTime += Time.deltaTime;
    }
    private void spawnBeat()
    {
        Instantiate(beat, spawnPoints[Random.Range(0,spawnPoints.Length)]);
    }
}
