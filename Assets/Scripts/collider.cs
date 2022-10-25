using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collider : MonoBehaviour
{
    public Text scoretxt;
    private int score;


    // Use this for initialization
    void Start()
    {

      scoretxt.GetComponent<Text>() ;

    }


    // Update is called once per frame
    void Update()
    {

        scoretxt.text = "Score: 0 " + score;

    }


    void OnTriggerEnter(Collider coll)
    {

        score = score + 1;

    }


}
 

