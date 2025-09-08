using UnityEngine;

[System.Serializable] 

public class Ability
{

    public int Strength { get; set; }   

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Ability()
    {
        Debug.Log("Created Ability Instance"); 
    }
    void Start()
    {
        // strength = 777;
        Debug.Log("strenth : " + Strength);
        
    }

    // Update is called once per frame 
    void Update() 
    {
        
    }
}
