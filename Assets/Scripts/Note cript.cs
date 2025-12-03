using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Notecript : MonoBehaviour
{

    public TMP_Text Health;
   
    public float Movemnetspeed = 5;
  
    public bool IsDestroyed = false;
    
    public Health health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health= FindFirstObjectByType<Health>();
        
    }

   
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * Movemnetspeed * Time.deltaTime;
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Note"))
        {
            IsDestroyed = true;
            Destroy(gameObject);
            health.Points -= 1;
        }
    }
}
