using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Playermovments : MonoBehaviour
{
    public GameObject LeftLane;
    public GameObject RightLane;
    public GameObject Middlelane;
    public GameObject Note;
    public float jumppower = 3;
    
    public float playerpos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    public void OnCollisionEnter(Collision collision)
    {
             if (gameObject.CompareTag("Note"))
             {
            Debug.Log("attack");
                Destroy(Note);
             }
        

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up * jumppower * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = LeftLane.transform.position;
           
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = Middlelane.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = RightLane.transform.position;
        }

       
    }

}