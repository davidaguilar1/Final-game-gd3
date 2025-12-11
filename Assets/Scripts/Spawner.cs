using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using NUnit.Framework.Internal;
using NUnit.Framework;

public class Spawner : MonoBehaviour
{
    public Shader water;
    public GameObject Square;
    public Health HP;
    public Notecript Move;
    public float timer = 0f;
    private float MaxSpawnInterval = 4f;
    private float MinSpawnInterval = 0f;
    private float SpawnRate;
    public TMP_Text below50;
    public Health IsWin;
    private bool hasRunBelow50 = false;
    void Start()
    {
        
        HP = FindAnyObjectByType<Health>();
        SpawnRate = Random.Range(MinSpawnInterval, MaxSpawnInterval);
        below50.enabled = false;
       
    }

    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= SpawnRate)
        {
            timer = 0f;
            Instantiate(Square, transform.position, transform.rotation);
            SpawnRate = Random.Range(MinSpawnInterval, MaxSpawnInterval);
        }
        if( HP.Points <= 99 && !hasRunBelow50)
        {
            Debug.Log("Below 50");
            StartCoroutine(Below50());
            hasRunBelow50 = true;
        }
        
    }
    
    private IEnumerator Below50()
    {
        
        below50.enabled = true;
        Notecript[] holder = FindObjectsByType<Notecript>(FindObjectsSortMode.None);
        foreach (Notecript note in holder)
        {
            note.gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(3);
       below50.enabled = false;
        Debug.Log("Above 50");
        foreach (Notecript note in holder)
        {
            note.gameObject.SetActive(true);
        }
        
        Move.Movemnetspeed = 15;
       
    }
}
