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
    public AudioSource Bossmusic;
    public AudioSource Normal;
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

    public static bool didChangeWater;
    public static bool didmusicplay;
    //material handling
    public MeshRenderer waterMesh;
    public Material normalMaterial, scaryMaterial;
    void Start()
    {
        
        HP = FindAnyObjectByType<Health>();
        SpawnRate = Random.Range(MinSpawnInterval, MaxSpawnInterval);
        below50.enabled = false;
    
      Bossmusic.Stop();
        Normal.Play();
    }

    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= SpawnRate)
        {
            timer = 0f;
            Instantiate(Square, transform.position, transform.rotation, transform);
            SpawnRate = Random.Range(MinSpawnInterval, MaxSpawnInterval);
        }
        if( HP.Points <= 50 && !hasRunBelow50)
        {
            Debug.Log("Below 50");
            StartCoroutine(Below50());
            hasRunBelow50 = true;
        }
       
    }
    
    private IEnumerator Below50()
    {
        Normal.Stop();
        below50.enabled = true;
        if (!Spawner.didChangeWater)
        {
            waterMesh.material = scaryMaterial;
            Spawner.didChangeWater = true;
        }
       
            Bossmusic.Play(2);
            
        
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
            Destroy(note.gameObject);
        }
        
        Move.Movementspeed = 40;
        MaxSpawnInterval = 2;
    }
}
