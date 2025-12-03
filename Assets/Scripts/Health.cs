using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class Health : MonoBehaviour
{

    public TMP_Text Healthy;
    public int Points;
    public bool IsWin;
    public GameObject note;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        Healthy.text = "Boss Health: " + Mathf.Round(Points).ToString();
       if(Points == -10)
        {
            
            IsWin = true;
            //StartCoroutine(Win());
        }
    }

   // private IEnumerator Win()
    //{
     //   Debug.Log("Started");
   // }
    
}
