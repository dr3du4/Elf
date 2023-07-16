using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public bool isActive = false;

    public GameObject window;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && isActive)
        {
            Debug.Log("ZAMKNIECIE");
            isActive = false;
            window.SetActive(false);
        }       
        else if (Input.GetKeyDown(KeyCode.I) && isActive==false)
        {
            Debug.Log("OTWARCIE");
            isActive = true;
            window.SetActive(true);
        }       
    }

    void Awake()
    {
        
    }
}
