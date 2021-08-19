using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    public void LogTargetName(object target)
    {
        GameObject log = (GameObject)target;
        print(log.name);
    }
}
