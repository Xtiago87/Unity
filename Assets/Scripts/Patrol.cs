using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{


    public float speed;
    public Transform[] moveSpots;
    private int randoSpot;
    public float startWaitTime;
private float waitTime;
    

    // Start is called before the first frame update
    void Start()
    {

randoSpot = Random.Range(0, moveSpots.Length);


    }

    // Update is called once per frame
    void Update()
    {
        
transform.position = Vector2.MoveTowards(transform.position, moveSpots[randoSpot].position, speed * Time.deltaTime);

if(Vector2.Distance(transform.position, moveSpots[randoSpot].position) < 0.2f){
    if(waitTime <= 0){
        randoSpot = Random.Range(0, moveSpots.Length);
    }else{
waitTime -= Time.deltaTime;
    }
}



    }
}
