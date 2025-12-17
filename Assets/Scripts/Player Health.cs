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
    public AudioSource below5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerHealthPoints = 10;
        PlayerHP.value = PlayerHealthPoints;
        below5.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        Playerhealth.text = "HP: " + Mathf.Round(PlayerHealthPoints).ToString();
        PlayerHP.value = PlayerHealthPoints / 10f;
        if(PlayerHealthPoints <= 5)
        {
            StartCoroutine(Below5());
        }
        if (PlayerHealthPoints <= 0)
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
