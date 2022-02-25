using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangedAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Changed animators
    public void getAnimateDance(){
        this.GetComponent<Animator>().Play("dance");
    }
    public void getAnimateWolking(){
        this.GetComponent<Animator>().Play("walking");
    }
}
