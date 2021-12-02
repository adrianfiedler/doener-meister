using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeineMutter : MonoBehaviour
{
    public GameObject deinVater;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered your Mother");
        Animation anim = deinVater.GetComponent<Animation>();
        anim.Play("DoorOpen");
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Left your Mother");
        Animation anim = deinVater.GetComponent<Animation>();
        anim.Play("DoorClose");
    }
}
