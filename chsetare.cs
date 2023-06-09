using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chsetare : MonoBehaviour
{
    public GameObject effect;
    void OnCollisionEnter2D(Collision2D col)
    {
         
        if (col.gameObject.tag == "death")
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            col.transform.rotation = Quaternion.identity;

        }
    }
}
