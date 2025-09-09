using UnityEngine;
using UnityEngine.UI; 

public class BtnMgr : MonoBehaviour
{
    [SerializeField] Button[] btns; 
    
    void Start()
    { 
        
    }

    public void Excute()
    {
        Debug.Log("Excute"); 
    }

    public void Config()
    {
        Debug.Log("Config"); 
    }

    public void Quit() 
    {
        Debug.Log("Quit"); 
    } 
}
