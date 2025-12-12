using UnityEngine;
using TMPro;
public class ComboScript : MonoBehaviour
{
    public TMP_Text Combo;
    public Spawner IfNoteDes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IfNoteDes.Square)
        {
            Combo.text = "Combo " + Mathf.Round(1).ToString();
        }
    }
}
