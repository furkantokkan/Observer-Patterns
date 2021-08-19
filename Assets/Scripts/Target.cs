using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Event picked;
    public Event getTarget;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            picked.Occurred(2);
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        getTarget.Occurred(gameObject);
    }
}
