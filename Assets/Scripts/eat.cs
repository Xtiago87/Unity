using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class eat : MonoBehaviour
{

    public float Increase;
    public float Decrease;
    public float Speed;

    //private Transform target;

    public float power = 1;
    public float powerTimeR = 0;
    public float timePassedR = 0;
    public float powerTimeE = 0;
    public float extraLife = 0;

    public bool isRespiradorEat = false;
    public bool isEvaEat = false;
    public bool isVacina1 = false;
    public bool isVacina2 = false;

    public string sceneName;

    void OnCollisionEnter2D(Collision2D col)
    {

        if (transform.localScale.x > col.gameObject.transform.localScale.x && transform.localScale.y > col.gameObject.transform.localScale.y)
        {

            if (col.gameObject.tag == "teste")
            {

                Destroy(col.gameObject);
            }
        }


        if (col.gameObject.tag == "MascaraC")
        {

            transform.localScale += new Vector3(0.1f * power, 0.1f * power); // +10 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.5f * power;

        }
        else if (col.gameObject.tag == "MascaraP")
        {

            transform.localScale += new Vector3(0.2f * power, 0.2f * power); // +20 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.75f * power;

        }
        else if (col.gameObject.tag == "Alcool")
        {

            transform.localScale += new Vector3(0.01f * power, 0.01f) * power; // +1 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.25f * power;

        }
        else if (col.gameObject.tag == "FaceShield")
        {

            transform.localScale += new Vector3(0.2f * power, 0.2f * power); // +20 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.75f * power;

        }
        else if (col.gameObject.tag == "Respirador")
        {

            Destroy(col.gameObject);
            isRespiradorEat = true;
            Camera.main.orthographicSize += 1f * power;

        }
        else if (col.gameObject.tag == "Elmo")
        {
            extraLife++;
            Destroy(col.gameObject);

        }
        else if (col.gameObject.tag == "Eva")
        {

            Destroy(col.gameObject);
            isEvaEat = true;
            power = 2;
            Speed = Speed * 1.5f;

        }
        else if (col.gameObject.tag == "Ambulancia")
        {
            Speed += 2;

            Destroy(col.gameObject);

        }
        else if (col.gameObject.tag == "Espinho")
        {
            transform.localScale -= new Vector3(0.05f * power, 0.05f * power); // -5 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize -= 0.25f * power;
        }
        else if (col.gameObject.tag == "Vacina1")
        {
            isVacina1 = true;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Vacina2")
        {
            isVacina2 = true;
            Destroy(col.gameObject);
        }
    }

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        
    }

    void Update()
    {
        var renderer = gameObject.GetComponent<Renderer>();
        float x = renderer.bounds.size.x;
        float y = renderer.bounds.size.y;

        if(sceneName == "SampleScene")
        {
            if (x >= 20 && y >= 20)
            {
                Debug.Log("Vacinado");
                SceneManager.LoadScene("Ceara");
            }
        }
        if (sceneName == "Ceara")
        {
            if (x >= 22.5 && y >= 22.5 && isVacina1 == true)
            {
                SceneManager.LoadScene("Brasil");
            }
        }
        if (sceneName == "Brasil" && isVacina2 == true)
        {
            if (x >= 22.5 && y >= 22.5)
            {
                SceneManager.LoadScene("Mundo");
            }
        }
        if (sceneName == "Mundo" )
        {
            if (x >= 50 && y >= 50)
            {
                //SceneManager.LoadScene("");
            }
        }

        // if(GameObject.FindGameObjectWithTag("teste").GetComponent<Transform>() != null){
        //   target = GameObject.FindGameObjectWithTag("teste").GetComponent<Transform>();
        //     }


        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = transform.position.z;


        transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime / (transform.localScale.x / 2 ));

        if (isEvaEat)
        {

            powerTimeE += Time.deltaTime;

            if (powerTimeE >= 10)
            {
                isEvaEat = false;
                powerTimeE = 0;
                Speed = Speed / 1.5f;
            }
        }

        if (isRespiradorEat)
        {

            powerTimeR += Time.deltaTime;

            if (powerTimeR > timePassedR)
            {
                transform.localScale += new Vector3(0.1f * power, 0.1f * power); // +5 power per second
                timePassedR++;
            }
            if (powerTimeR >= 5)
            {
                isRespiradorEat = false;
                timePassedR = 0;
                powerTimeR = 0;
            }
        }

    }
}