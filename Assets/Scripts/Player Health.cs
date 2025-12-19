using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public Slider PlayerHP;
    public TMP_Text Playerhealth;
    public int PlayerHealthPoints;
    public float TookDamage;
    public bool DidLose;
    public AudioSource below5;
    public AudioSource glass1;
     public AudioSource glass2;
 
    public TMP_Text GameOverText;
    public Spawner spawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerHealthPoints = 20;
        PlayerHP.value = PlayerHealthPoints;
        below5.Stop();
        spawner = FindAnyObjectByType<Spawner>();
        GameOverText.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        Playerhealth.text = "HP: " + Mathf.Round(PlayerHealthPoints).ToString();
        PlayerHP.value = PlayerHealthPoints / 20f;
        if(PlayerHealthPoints <= 5)
        {
            StartCoroutine(Below5());
        }
      
        if(TookDamage >= 1)
        {
            int glassSound = Random.Range(0, 2);
            if(glassSound == 0)
            {
                glass1.Play();
            }
            else
            {
                glass2.Play();
            }
            TookDamage = 0;
        }
        if(DidLose)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private IEnumerator Below5()
    {
        yield return null;
        below5.Play();
    }
    
}
