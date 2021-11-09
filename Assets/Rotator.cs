using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField]
    [Tooltip("How speed the object rotate ")]
    float speed = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.Self);
    }
}
