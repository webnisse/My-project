using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{

    int counter = 0;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {




    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Key")
        {

            counter++;

            scoreText.text = counter.ToString();


        }
    }


}
