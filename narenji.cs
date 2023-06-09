using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narenji : MonoBehaviour
{
    public float speed;
    float ttime;

    // Start is called before the first frame update
    void Start()
    {
        if (score.Score < 200)
        { speed = 3.5f; }
        else
        { speed = 0.00009f * score.Score + speed; }

    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(Vector2.down * speed * Time.deltaTime);
        //transform.Translate(Vector2.down * speed);
        //speed += 0.05f;
       
    }
}
