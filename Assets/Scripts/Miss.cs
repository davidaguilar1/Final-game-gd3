using UnityEngine;

public class Miss : MonoBehaviour
{
    public PlayerHealth PlayHP;
    public PlayerHealth Damagetaken;
    public Health Combos;
    public GameObject Note;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayHP = FindAnyObjectByType<PlayerHealth>();
        Combos = FindAnyObjectByType<Health>();
        Damagetaken = FindAnyObjectByType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
       PlayHP.PlayerHealthPoints -= 1;
        Damagetaken.TookDamage += 1;
        Combos.Score = 0;
       
        
    }
}
