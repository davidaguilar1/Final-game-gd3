using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Square;

    private float timer = 0f;
    private float SpecialTimer = 0f;
    private float SpawnRate;
    void Start()
    {
        
    }

    void Update()
    {

        timer += Time.deltaTime;
        SpecialTimer += Time.deltaTime;
        if (timer == 2f)
        {
            timer = 0f;
            Instantiate(Square, transform.position, transform.rotation);
        }
    }
}
