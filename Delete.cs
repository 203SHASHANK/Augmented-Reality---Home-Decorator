using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public GameObject furniture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onbutton()
    {
        if(furniture.activeInHierarchy == true)
            furniture.SetActive(false);
    }
}
