using UnityEngine;
using UnityEngine.SceneManagement;

public class HowTo : MonoBehaviour
{
    private string howToLevel = "HowToPlay";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HowToButton()
    {
        SceneManager.LoadScene(howToLevel);
    }
}
