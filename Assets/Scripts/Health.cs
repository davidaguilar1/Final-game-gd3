using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Health : MonoBehaviour
{

    public TMP_Text Healthy;
    public TMP_Text Combotext;
    public Slider slider;
    public int Points;
    public int Score;
    public bool IsWin;
    public GameObject note;
    public float HighCombo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsWin = false;
        slider.value = Points;
        Points = 200;
        Score= 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        Healthy.text = "HP: " + Mathf.Round(Points).ToString();
        Combotext.text = "Combo " + Mathf.Round(Score).ToString();
        slider.value = Points / 200f;
       
       
        if(Points == 0)
        {
            SceneManager.LoadScene("Win");
        }

    }



}
