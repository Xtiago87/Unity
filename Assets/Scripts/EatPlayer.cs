using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatPlayer : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
     
        
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (transform.localScale.x > target.localScale.x && transform.localScale.y > target.localScale.y) {
       
           if(col.gameObject.tag == "Player")
        {
     
            Destroy(col.gameObject);
        }
        }
     

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
