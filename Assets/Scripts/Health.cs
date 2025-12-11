using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.UI;
public class Health : MonoBehaviour
{

    public TMP_Text Healthy;
    public Slider slider;
    public int Points;
    public bool IsWin;
    public GameObject note;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsWin = false;
        slider.value = Points;
        Points = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Healthy.text = "Boss Health: " + Mathf.Round(Points).ToString();
        slider.value = Points/ 100f;
    }


    
}
