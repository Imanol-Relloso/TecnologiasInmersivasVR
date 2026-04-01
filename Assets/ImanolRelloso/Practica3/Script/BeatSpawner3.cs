using UnityEngine;

public class BeatSpawner3 : MonoBehaviour
{
    private Transform[] spawnPoints;

    [SerializeField] private GameObject beat;
    [SerializeField] private GameObject arrowBeat;

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
        if (BeatManager3.instance.final) return;

        if (spawnTime <= waitedTime)
        {
            spawnBeat();
            waitedTime = 0;
        }
        waitedTime += Time.deltaTime;
    }
    private void spawnBeat()
    {
        if (GameManager3.instance.gameMode == GameMode.Arrow)
        {
            Instantiate(arrowBeat, spawnPoints[Random.Range(0, spawnPoints.Length)]);
        }
        else 
        {
            GameObject b = Instantiate(beat, spawnPoints[Random.Range(0, spawnPoints.Length)]);

            if (GameManager3.instance.gameMode == GameMode.Bomb)
            {
                if (Random.Range(0, 100) < bombProb)
                    b.GetComponent<Beat3>().bomb = true;
                else
                    b.GetComponent<Beat3>().bomb = false;
            }
        }
    }
}
