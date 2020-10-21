using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Add " + add(404, 4));

    }

    // Update is called once per frame
    void Update()
    {

    }


    int add(int a, int b)
    {
        return (a + b);

    }

}
