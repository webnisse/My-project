using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{

    [SerializeField]
    GameObject Circle;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-7f, 12f);
         float y = Random.Range(-5f, 5f);

        Vector2 position = new Vector2(x, y);

        transform.position = position;

         
        

    }

    // Update is called once per frame
    void Update()
    {
     


    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            
         float x = Random.Range(-7f, 12f);
         float y = Random.Range(-5f, 5f);
             Vector2 position = new Vector2(x, y);

          transform.position = position;
        }


    }
}
