using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float moveSpeed = 20f; 
    
    void Start()
    {      
    } 

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); 
        float v = Input.GetAxisRaw("Vertical");    
                
        Vector3 dir = new Vector3(h, 0f, v).normalized; 
        
        transform.Translate(dir * moveSpeed * Time.deltaTime, Space.Self);         
    }
}
