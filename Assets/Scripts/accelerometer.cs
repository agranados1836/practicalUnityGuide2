using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerometer : MonoBehaviour
{
    public GameObject Sphere;
    float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.x = -Input.acceleration.y;
        dir.y = Input.acceleration.x;

        if (dir.sqrMagnitude > 1)
            dir.Normalize();


        dir *= Time.deltaTime;
        Sphere.transform.Translate(dir * speed);
    }
}
