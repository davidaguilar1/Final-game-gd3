using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Square;

    public float timer = 0f;
    private float SpecialTimer = 0f;
    private float MaxSpawnInterval = 4f;
    private float MinSpawnInterval = 0f;
    private float SpawnRate;

    public Health IsWin;
    void Start()
    {
        IsWin = FindAnyObjectByType<Health>();
        SpawnRate = Random.Range(MinSpawnInterval, MaxSpawnInterval);
    }

    void Update()
    {

        timer += Time.deltaTime;
        SpecialTimer += Time.deltaTime;
        if (timer >= SpawnRate)
        {
            timer = 0f;
            Instantiate(Square, transform.position, transform.rotation);
            SpawnRate = Random.Range(MinSpawnInterval, MaxSpawnInterval);
        }
        if (IsWin == true)
        {
            Debug.Log("End");
            Destroy(this);
        }
    }
}
