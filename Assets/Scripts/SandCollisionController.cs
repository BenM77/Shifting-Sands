//Ben Michael and Tristan Hildahl
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandCollisionController : MonoBehaviour
{
    public GameObject Mud;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Water")
        {
            Vector3 newPosition = this.transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            Instantiate(Mud, newPosition, Quaternion.identity);
        }
    }
}
