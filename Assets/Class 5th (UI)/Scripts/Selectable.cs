using UnityEngine;
using UnityEngine.UI;

public class Selectable : MonoBehaviour
{
    [SerializeField] Text titleText; 
    public void Enter()
    {
        titleText.fontSize = 100;
    }

    public void Exit()
    {
        titleText.fontSize = 75;
    }

    public void Down()
    {
        titleText.fontSize = 50; 
    }

    private void Awake()
    {
        //titleText = GetComponentInChildren<Text>(); 
    }

    void Start()
    {         
    }

  
    void Update()
    {
        
    }
}
