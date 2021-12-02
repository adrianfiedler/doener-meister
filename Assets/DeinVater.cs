using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeinVater : MonoBehaviour
{
    bool isOpening = false;
    bool isClosing = false;
    public float degreesPerSecond = 20.0f;

    public void Open()
    {
        isOpening = true;

    }

    public void Close()
    {
        isOpening = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isOpening)
        {
            gameObject.transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);
        }
        if(gameObject.transform.rotation.y >= 50.0f)
        {
            isOpening = false;
        }

        if (isClosing)
        {
            gameObject.transform.Rotate(0, -1 * degreesPerSecond * Time.deltaTime, 0);
        }
        if (gameObject.transform.rotation.y <= 0.0f)
        {
            isClosing = false;
        }
    }
}
