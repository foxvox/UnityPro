using System;
using UnityEngine;
using UnityEngine.UI; 

public class BtnMgr : MonoBehaviour
{
    [SerializeField] Button[] btns;
    [SerializeField] Action[] actions = { Excute, Config, Quit }; 
    [SerializeField] string[] txts = new string[3] { "Start", "Config", "Quit" }; 

    void Start()
    {
        for (int i = 0; i < btns.Length; i++)  
        {
            int index = i;  
            // ¶÷´Ù expression 
            btns[i].onClick.AddListener(() => actions[index]()); 
            btns[i].GetComponentInChildren<Text>().text = txts[index]; 
        } 
    }

    public static void Excute() 
    { 
        Debug.Log("Execute"); 
    } 

    public static void Config()
    {
        Debug.Log("Config"); 
    }

    public static void Quit() 
    {
        Debug.Log("Quit"); 
    } 
}


