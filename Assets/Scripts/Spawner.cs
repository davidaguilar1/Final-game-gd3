using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using NUnit.Framework.Internal;

public class Spawner : MonoBehaviour
{

    public GameObject Square;
    public Health HP;
    public Notecript Move;
    public float timer = 0f;
    private float SpecialTimer = 0f;
    private float MaxSpawnInterval = 4f;
    private float MinSpawnInterval = 0f;
    private float SpawnRate;
    public TMP_Text below50;
    public Health IsWin;

    void Start()
    {
        
        HP = FindAnyObjectByType<Health>();
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
        if( HP.Points == -50)
        {
            StartCoroutine(Below50());
        }
        
    }
    
    private IEnumerator Below50()
    {
        Debug.Log("Below 50");
        Notecript[] holder = FindObjectsByType<Notecript>(FindObjectsSortMode.None);
        foreach(Notecript Note in holder)
        {
            Destroy(Square);
        }
        yield return new WaitForSeconds(5);
        MaxSpawnInterval = 3f;
        Move.Movemnetspeed = 10f;
       
    }
}
