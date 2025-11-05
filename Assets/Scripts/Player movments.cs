using UnityEngine;

public class Playermovments : MonoBehaviour
{
    public GameObject LeftLane;
    public GameObject RightLane;
    public GameObject Middlelane;

    public float LeftPos;
    public float MiddlePos;
    public float RightPos;
    public bool PlayerPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {

        }
    }
}
