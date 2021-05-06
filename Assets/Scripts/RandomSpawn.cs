using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Food;
    public float vel;
    private Vector3 scaleChange;
    private Transform playerPos;


    void FoodGenerate()
    {
        int x = Random.Range(0, Camera.main.pixelWidth);
        int y = Random.Range(0, Camera.main.pixelHeight);
  Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));
Debug.Log("pos player = " + playerPos.position);
Debug.Log("pos inimigo = " + Target);
Debug.Log("distancia entre os dois = " + Vector3.Distance(Target, playerPos.position));
if(Vector3.Distance(Target, playerPos.position) > 10){
    Vector3 newTarget = Camera.main.ScreenToWorldPoint(new Vector3(x + 500, y + 500, 0));
        Target.z = 0;
Debug.Log("Perto " + "pos antiga  = " + Target);
Debug.Log("Perto " + "pos nova   = " +  newTarget);
        float tam = Random.Range(0, 1f);
        

        scaleChange = new Vector3(tam, tam, 0);
        Food.transform.localScale +=  scaleChange;
        
       


            Instantiate(Food, newTarget, Quaternion.identity);
    
}else{
        Target.z = 0;
Debug.Log("Longe: ");
        float tam = Random.Range(0, 1f);
        

        scaleChange = new Vector3(tam, tam, 0);
        Food.transform.localScale +=  scaleChange;
        
       


            Instantiate(Food, Target, Quaternion.identity);
    
}
        
    }

    // Start is called before the first frame update
    void Start()
    {
 playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

                InvokeRepeating("FoodGenerate", 1, vel);
         
    }

    // Update is called once per frame
    void Update()
    {

    }
}