using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardScriptCamera : MonoBehaviour
{
    public bool frontView = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (frontView == true)
        {
            transform.Translate(0.05f, 0f, 0f);
        } else if (frontView == false)
        {
            transform.Translate(0f, 0f, 0.05f);
        }
    }
}
