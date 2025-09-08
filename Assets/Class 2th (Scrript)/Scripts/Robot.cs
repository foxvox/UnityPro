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
        // 객체가 활성화 되었을 때 호출되는 이벤트 함수입니다. 
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
        // 한 프레임의 마지막 단계에서 호출되는 이벤트 함수입니다. 
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
