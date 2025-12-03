using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{

    public TMP_Text Healthy;
    public int Points;
    public GameObject note;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Healthy.text = "Boss Health: " + Mathf.Round(Points).ToString();
    }
}
