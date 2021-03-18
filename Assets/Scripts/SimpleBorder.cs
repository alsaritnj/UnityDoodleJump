using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBorder : MonoBehaviour
{
    public float TeleportationPointX = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = new Vector3(TeleportationPointX, other.transform.position.y, other.transform.position.z);
    }
}
