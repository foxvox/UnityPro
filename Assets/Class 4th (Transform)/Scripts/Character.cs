using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Move))] 

public class Character : MonoBehaviour
{
    [SerializeField] Move moveObj;

    private void Awake()
    {
        moveObj = GetComponent<Move>(); 
    }

    void Start()
    {} 

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0f, v);

        moveObj.OnMove(dir, 20);
    }
}
