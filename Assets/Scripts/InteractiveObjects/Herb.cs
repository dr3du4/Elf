using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Herb : MonoBehaviour
{
    public GameObject player;
    public GameObject herb;
    public float grabRadius;
    public GameObject infoWindow;
    public TMP_Text name;

    
  
    void Update()
    {
        
        Vector3 position1 = player.transform.position;
        Vector3 position2 = herb.transform.position;
        float distance = Vector3.Distance(position1, position2);

        if (distance < grabRadius  && infoWindow != null)
        {
            
            infoWindow.SetActive(true);
            
        }
        if (Input.GetKeyDown(KeyCode.G) && distance < grabRadius)
        {
            Debug.Log("DAJ MNIE TO");
            Destroy(herb);
        }

        if (distance > grabRadius && herb != null)
        {
            infoWindow.SetActive(false);
            
            
        }
        
    }

 

}
