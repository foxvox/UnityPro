using UnityEngine;

public class ItemMgr : MonoBehaviour 
{
    [SerializeField] Item[] items;

    private int cnt = 0; 
    
    void Start() 
    {} 

    void Update() 
    {
        if (Input.GetMouseButtonDown(0)) 
        {            
            items[cnt].Activate(); 
            cnt = ++cnt % items.Length;
        }
    }
}
