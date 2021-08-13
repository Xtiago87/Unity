using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Timers;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Food;
    public float vel;
    public float velItens;
    
    public GameObject alcool;
    public GameObject ambulance;
    public GameObject elmo;
    public GameObject eva;
    public GameObject faceShield;
    public GameObject mask1;
    public GameObject mask2;
    public GameObject respirador;
    public GameObject Vacina1;
    public GameObject Vacina2;

    private string sceneName;
    public GameObject mapa;
    private static System.Timers.Timer aTimer;
    public float timeRemainingCeara = 30;
    public float timeRemainingBR = 40;
    private bool spawnVacina1 = false;
    private bool spawnVacina2 = false;
    private Vector3 scaleChange;
    Vector2 pos;


    void FoodGenerate()
    {
       MeshCollider c = mapa.GetComponent<MeshCollider>();
       float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
       float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

       pos = new Vector2(x,y);

       float tam = Random.Range(0, 0.5f);
       
       scaleChange = new Vector3(tam, tam, 0);
       Food.transform.localScale +=  scaleChange;


       Instantiate(Food, pos, Quaternion.identity);
            
    }


    void SpawnItens(){
       var i = 0;

       while(i<10){
       
       if(sceneName == "Fortaleza"){
    
              if(i == 0){  //alcool
              var a = 0;
                     while(a < 4){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);
                   

                     Instantiate(alcool, pos, Quaternion.identity);
                     a++;
                     }
              }else if(i == 1){    //ambulance
                     int num = Random.Range(0, 5);
                     Debug.Log(num);
                     if(num == 1){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);


                     Instantiate(ambulance, pos, Quaternion.identity);   
              }
       }else if(i == 3){ // eva
                     int num = Random.Range(0, 15);
                     Debug.Log(num);
                     
                     if(num == 1){
                   
                      MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(eva, pos, Quaternion.identity);
              }

              }else if(i == 4){ //faceShield
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(faceShield, pos, Quaternion.identity);
              }else if(i == 5){ // mask 1 
                     var a = 0;
                     while(a < 4){
                    MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(mask1, pos, Quaternion.identity);
                     a++;
                     }
              }else if(i == 6){ // mask 2
                     var a = 0;
                     while(a < 2){
                  MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(mask2, pos, Quaternion.identity);
                     a++;
              }

              }else if(i == 7){ //respirador
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(respirador, pos, Quaternion.identity);

              }
              }else if(sceneName == "Ceara"){
if(i == 0){  //alcool
              var a = 0;
                     while(a < 5){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);
                   

                     Instantiate(alcool, pos, Quaternion.identity);
                     a++;
                     }
              }else if(i == 1){    //ambulance
                     int num = Random.Range(0, 5);
                     Debug.Log(num);
                     if(num == 1){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);


                     Instantiate(ambulance, pos, Quaternion.identity);   
              }

              }else if(i == 2){ //elmo
//botar pra spawnar e olhe la
                     int num = Random.Range(0, 100);
                     Debug.Log(num);
                     if(num == 1){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(elmo, pos, Quaternion.identity);
              }

              }else if(i == 3){ // eva
                     int num = Random.Range(0, 15);
                     Debug.Log(num);
                     
                     if(num == 1){
                   
                      MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(eva, pos, Quaternion.identity);
              }

              }else if(i == 4){ //faceShield
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(faceShield, pos, Quaternion.identity);
              }else if(i == 5){ // mask 1 
                     var a = 0;
                     while(a < 6){
                    MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(mask1, pos, Quaternion.identity);
                     a++;
                     }
              }else if(i == 6){ // mask 2
                     var a = 0;
                     while(a < 4){
                  MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(mask2, pos, Quaternion.identity);
                     a++;
              }

              }else if(i == 7){ //respirador
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(respirador, pos, Quaternion.identity);

              }else if(i == 8){//vacina 1 dps ver um jeito legal de spawnar ela
                   
                    

              }

              }else if(sceneName == "Brasil"){

if(i == 0){  //alcool
              var a = 0;
                     while(a < 5){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);
                   

                     Instantiate(alcool, pos, Quaternion.identity);
                     a++;
                     }
              }else if(i == 1){    //ambulance
                     int num = Random.Range(0, 2);
                     Debug.Log(num);
                     if(num == 1){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);


                     Instantiate(ambulance, pos, Quaternion.identity);   
              }

              }else if(i == 2){ //elmo
//botar pra spawnar e olhe la
                     int num = Random.Range(0, 100);
                     Debug.Log(num);
                     if(num == 1){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(elmo, pos, Quaternion.identity);
              }

              }else if(i == 3){ // eva
                     int num = Random.Range(0, 15);
                     Debug.Log(num);
                     
                     if(num == 1){
                   
                      MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(eva, pos, Quaternion.identity);
              }

              }else if(i == 4){ //faceShield
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(faceShield, pos, Quaternion.identity);
              }else if(i == 5){ // mask 1 
                     var a = 0;
                     while(a < 6){
                    MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(mask1, pos, Quaternion.identity);
                     a++;
                     }
              }else if(i == 6){ // mask 2
                     var a = 0;
                     while(a < 4){
                  MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(mask2, pos, Quaternion.identity);
                     a++;
              }

              }else if(i == 7){ //respirador
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(respirador, pos, Quaternion.identity);

              }
              }else if(sceneName == "Mundo"){

if(i == 0){  //alcool
              var a = 0;
                     while(a < 5){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);
                   

                     Instantiate(alcool, pos, Quaternion.identity);
                     a++;
                     }
              }else if(i == 1){    //ambulance
                     int num = Random.Range(0, 5);
                     Debug.Log(num);
                     if(num == 1){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);


                     Instantiate(ambulance, pos, Quaternion.identity);   
              }

              }else if(i == 2){ //elmo
//botar pra spawnar e olhe la
                     int num = Random.Range(0, 100);
                     Debug.Log(num);
                     if(num == 1){
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(elmo, pos, Quaternion.identity);
              }

              }else if(i == 3){ // eva
                     int num = Random.Range(0, 15);
                     Debug.Log(num);
                     
                     if(num == 1){
                   
                      MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(eva, pos, Quaternion.identity);
              }

              }else if(i == 4){ //faceShield
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(faceShield, pos, Quaternion.identity);
              }else if(i == 5){ // mask 1 
                     var a = 0;
                     while(a < 6){
                    MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(mask1, pos, Quaternion.identity);
                     a++;
                     }
              }else if(i == 6){ // mask 2
                     var a = 0;
                     while(a < 4){
                  MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(mask2, pos, Quaternion.identity);
                     a++;
              }

              }else if(i == 7){ //respirador
                     MeshCollider c = mapa.GetComponent<MeshCollider>();
                     float x = Random.Range(c.bounds.min.x, c.bounds.max.x); 
                     float y = Random.Range(c.bounds.min.y, c.bounds.max.y);

                     pos = new Vector2(x,y);

                     Instantiate(respirador, pos, Quaternion.identity);

              }
              }


              i++;

       }




}

              // Start is called before the first frame update
              void Start()
              {
                     Scene currentScene = SceneManager.GetActiveScene();
                     sceneName = currentScene.name;   
                     Vacina1.SetActive(false);
                     Vacina2.SetActive(false);
                     //SpawnItens();
                     InvokeRepeating("FoodGenerate", 2, vel);
                     InvokeRepeating("SpawnItens", 2, velItens);
}





              // Update is called once per frame
              void Update()
              {
                     
                     if(sceneName == "Ceara"){
                          if(timeRemainingCeara > 0){
                            timeRemainingCeara -= Time.deltaTime;
                            Debug.Log("timer = " +timeRemainingCeara);
                      }else{
                            if(spawnVacina1 == false){
   

                    Vacina1.SetActive(true);

                     spawnVacina1 = true;
                            }
                  
                      }   
                     }else if(sceneName == "Brasil"){
                                 if(timeRemainingBR > 0){
                            timeRemainingBR -= Time.deltaTime;
                            Debug.Log("timer = " + timeRemainingBR);
                      }else{
                            if(spawnVacina2 == false){
                              Vacina2.SetActive(true);     
                              spawnVacina2 = true;
                            }
                  
                      }   
                     }
             
}

}