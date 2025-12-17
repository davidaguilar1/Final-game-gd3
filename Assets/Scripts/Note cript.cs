using UnityEngine;
using TMPro;


public class Notecript : MonoBehaviour
{

    public TMP_Text Health;
   
    public float Movementspeed;
  
    public bool IsDestroyed = false;
    
    public Health health;
    public Health Combo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health= FindFirstObjectByType<Health>();
        Combo= FindFirstObjectByType<Health>();
        Movementspeed = 20f;
    }

   
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * Movementspeed * Time.deltaTime;
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Note"))
        {
            IsDestroyed = true;
            Destroy(gameObject);
            health.Points -= 1;
            Combo.Score += 1;
        }
        
    }
}
