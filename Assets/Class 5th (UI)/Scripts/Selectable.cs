using UnityEngine;
using UnityEngine.UI;

public class Selectable : MonoBehaviour
{
    public void Enter()
    {
        Button button = GetComponent<Button>(); 
        button.GetComponentInChildren<Text>().fontSize = 100;
    }

    public void Exit()
    {
        Button button = GetComponent<Button>();
        button.GetComponentInChildren<Text>().fontSize = 75;
    }

    public void Down()
    {
        Button button = GetComponent<Button>();
        button.GetComponentInChildren<Text>().fontSize = 50;
    }

    void Start()
    { 

        
    }

  
    void Update()
    {
        
    }
}
