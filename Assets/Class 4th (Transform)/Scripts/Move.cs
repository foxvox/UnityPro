using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0f;

    public void OnMove(Vector3 _dir, float _moveSpeed) 
    {
        moveSpeed = _moveSpeed;  
        Vector3 dir = _dir.normalized;        
        transform.Translate(dir * _moveSpeed * Time.deltaTime, Space.Self); 
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
