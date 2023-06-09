using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class death : MonoBehaviour

{
    public static bool isGameOver=false;
    public GameObject effect;
    public GameObject Gameover;
    public GameObject taptostart;
    //public GameObject bestscore;
    public GameObject panelmeno;
    //public GameObject flesh;
    public GameObject lastscore;
    public GameObject wall;
    public GameObject bigstar;
    public GameObject bisgstarmother;

    void Start()
    {

        isGameOver = false;

    }


    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "death")
        {

            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(bigstar);
            Destroy(bisgstarmother);
            Gameover.SetActive(true);
            taptostart.SetActive(true);
            panelmeno.SetActive(true);
            isGameOver = true;
            wall.SetActive(false);

        }

    }
}
