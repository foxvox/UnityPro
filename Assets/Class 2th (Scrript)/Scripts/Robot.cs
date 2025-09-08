using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField] private Ability ability;

    private void Awake()
    {
        Debug.Log("Robot Awake");        
    }

    private void OnEnable() 
    {
        // ��ü�� Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�. 
        Debug.Log("Robot OnEnable"); 
    }

    void Start() 
    {
        Debug.Log("Robot Start");
        ability = new Ability(); 
    } 

    private void FixedUpdate() 
    {
        Debug.Log("Robot FixedUpdate"); 
    }

    void Update() 
    {
        Debug.Log("Robot Update");         
    }

    private void LateUpdate()
    {
        // �� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�. 
        Debug.Log("Robot LateUpdate"); 
    }

    private void OnDisable()
    {
        Debug.Log("Robot OnDisable"); 
    }

    private void OnDestroy()
    { 
        Debug.Log("Robot OnDestroy"); 
    }

}
