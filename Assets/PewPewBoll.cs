using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPewBoll : MonoBehaviour
{
    float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 10f, 0) * Time.deltaTime;
        Destroy(gameObject, 3);
    }
}
