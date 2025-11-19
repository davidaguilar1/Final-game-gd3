using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Notecript : MonoBehaviour
{
    
    public float Movemnetspeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Note"))
        {
          Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        {

        }
        transform.position += Vector3.back * Movemnetspeed * Time.deltaTime;
    }
}
