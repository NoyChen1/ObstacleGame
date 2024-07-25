using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float speed = 100f;
    float xAngle = 0;
    float yAngle = 0;
    float zAngle = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yAngle = Time.deltaTime * speed;
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
