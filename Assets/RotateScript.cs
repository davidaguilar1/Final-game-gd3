using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public Camera MainCam;
    public float rotationSpeed = 2;
    public float TimerSwitch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    
    void Update()
    {
        TimerSwitch += Time.deltaTime;
        if(TimerSwitch > 0 && TimerSwitch <= 5)
        {
            MainCam.transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        }
      if(TimerSwitch > 5 && TimerSwitch <= 10)
        {
            MainCam.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if(TimerSwitch > 10 && TimerSwitch <= 15)
        {
            MainCam.transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }
        if(TimerSwitch > 15 && TimerSwitch <= 20)
        {
            MainCam.transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }
        if(TimerSwitch > 20)
        {
            TimerSwitch = 0;
        }




    }
}
