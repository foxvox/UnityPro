using UnityEngine;

public class Character : MonoBehaviour
{
    private float moveSpeed = 20f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {      
    } 

    void Update()
    {
        float h = Input.GetAxis("Horizontal"); 
        float v = Input.GetAxis("Vertical");    
                
        Vector3 dir = new Vector3(h, 0f, v).normalized;
        
        transform.Translate(dir * moveSpeed * Time.deltaTime, Space.World);
    }
}
