using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangedColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function Changed Colors
    public void getRed()
    {
        this.GetComponent<Renderer>().material.color = Color.red;
    }
    public void getGreen()
    {
        this.GetComponent<Renderer>().material.color = Color.green;
    }
    public void getBlue()
    {
        this.GetComponent<Renderer>().material.color = Color.blue;
    }
}
