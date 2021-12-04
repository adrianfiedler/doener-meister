using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeineNeffe : MonoBehaviour
{
    public float degreesPerSecond = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, degreesPerSecond * Time.deltaTime);
    }
}
