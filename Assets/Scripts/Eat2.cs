using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Eat2 : MonoBehaviour
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

    public bool isEvaEat = false;
    public bool isVacina1Eat = false;
    public bool isVacina2Eat = false;
    public bool isMascaraCEat = false;
    public bool isMascaraPEat = false;
    public bool isAlcoolEat = false;
    public bool isFaceShieldEat = false;
    public bool isRespiradorEat = false;
    public bool isElmoEat = false;
    public bool isAmbulanciaEat = false;


    public string sceneName;

    public Text scoreText;
  public static  int score = Eat1.score;

    public Image itemEva;
    public Image itemMascaraC;
    public Image itemMascaraP;
    public Image itemAlcool;
    public Image itemFaceShield;
    public Image itemRespirador;
    public Image itemElmo;
    public Image itemAmbulancia;
    public Image itemVacina1;
    public Image itemVacina2;
    public Image itemElmoExtraLife;

    public Transform explosion;

   AudioSource source;
    public AudioClip clickButtonAudio;
    public AudioClip loseAudio;
    public AudioClip winAudio;

    public void AddPoint(int power)
    {
        score += power;
        scoreText.text = score.ToString();
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (transform.localScale.x > col.gameObject.transform.localScale.x && transform.localScale.y > col.gameObject.transform.localScale.y)
        {

            if (col.gameObject.tag == "teste")
            {
 Destroy(col.gameObject);
                          GameObject exploder = ((Transform)Instantiate(explosion, this.transform.position, this.transform.rotation)).gameObject;
                Destroy(exploder, 2.0f);
            }
        }


        if (col.gameObject.tag == "MascaraC")
        {
 source.PlayOneShot(clickButtonAudio, 0.7F);
            transform.localScale += new Vector3(0.1f * power, 0.1f * power); // +10 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.5f * power;
            AddPoint(10);
            isMascaraCEat = true;
        }
        else if (col.gameObject.tag == "MascaraP")
        {
 source.PlayOneShot(clickButtonAudio, 0.7F);
            transform.localScale += new Vector3(0.2f * power, 0.2f * power); // +20 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.75f * power;
            AddPoint(20);
            isMascaraPEat = true;
        }
        else if (col.gameObject.tag == "Alcool")
        {
 source.PlayOneShot(clickButtonAudio, 0.7F);
            transform.localScale += new Vector3(0.01f * power, 0.01f) * power; // +1 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.25f * power;
            AddPoint(1);
            isAlcoolEat = true;
        }
        else if (col.gameObject.tag == "FaceShield")
        {
 source.PlayOneShot(clickButtonAudio, 0.7F);
            transform.localScale += new Vector3(0.2f * power, 0.2f * power); // +20 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.75f * power;
            AddPoint(20);
            isFaceShieldEat = true;
        }
        else if (col.gameObject.tag == "Respirador")
        {
 source.PlayOneShot(clickButtonAudio, 0.7F);
            Destroy(col.gameObject);
            isRespiradorEat = true;
            Camera.main.orthographicSize += 1f * power;
            isRespiradorEat = true;

        }
        else if (col.gameObject.tag == "Elmo")
        {
            extraLife++;
            Destroy(col.gameObject);
            isElmoEat = true;
 source.PlayOneShot(clickButtonAudio, 0.7F);
        }
        else if (col.gameObject.tag == "Eva")
        {
 source.PlayOneShot(clickButtonAudio, 0.7F);
            Destroy(col.gameObject);
            isEvaEat = true;
            power = 2;
            Speed = Speed * 1.5f;

        }
        else if (col.gameObject.tag == "Ambulancia")
        {
            Speed += 2;
 source.PlayOneShot(clickButtonAudio, 0.7F);
            Destroy(col.gameObject);
            isAmbulanciaEat = true;

        }
        else if (col.gameObject.tag == "Espinho")
        {
             source.PlayOneShot(clickButtonAudio, 0.7F);
            transform.localScale -= new Vector3(0.05f * power, 0.05f * power); // -5 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize -= 0.25f * power;
        }
        else if (col.gameObject.tag == "Vacina1")
        {
             source.PlayOneShot(clickButtonAudio, 0.7F);
            isVacina1Eat = true;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Vacina2")
        {
             source.PlayOneShot(clickButtonAudio, 0.7F);
            isVacina2Eat = true;
            Destroy(col.gameObject);
        }
    }

    void Start()
    {
         source = GetComponent<AudioSource>();
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        scoreText.text = score.ToString();

        itemRespirador.enabled = false;
        itemEva.enabled = false;
        itemMascaraC.enabled = false;
        itemMascaraP.enabled = false;
        itemAlcool.enabled = false;
        itemFaceShield.enabled = false;
        itemRespirador.enabled = false;
        itemElmo.enabled = false;
        itemAmbulancia.enabled = false;
        itemElmoExtraLife.enabled = false;
        itemVacina1.enabled = false;
        itemVacina2.enabled = false;
    }

    void Update()
    {
        var renderer = gameObject.GetComponent<Renderer>();
        float x = renderer.bounds.size.x;
        float y = renderer.bounds.size.y;

        if (sceneName == "Fortaleza")
        {
            if (x >= 5 && y >= 5)
            {
                Debug.Log("Vacinado");
                SceneManager.LoadScene("Ceara");
            }
        }
        if (sceneName == "Ceara")
        {
            if (x >= 5 && y >= 5 && isVacina1Eat == true)
            {
                SceneManager.LoadScene("Brasil");
            }
        }
        if (sceneName == "Brasil" && isVacina2Eat == true)
        {
            if (x >= 5 && y >= 5)
            {
                SceneManager.LoadScene("Mundo");
            }
        }
        if (sceneName == "Mundo")
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

        transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime / transform.localScale.x);

        if (isEvaEat)
        {
            itemEva.enabled = true;

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

            itemRespirador.enabled = true;

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
        if (isMascaraCEat)
        {
            itemMascaraC.enabled = true;
        }
        if (isMascaraPEat)
        {
            itemMascaraP.enabled = true;
        }
        if (isAlcoolEat)
        {
            itemAlcool.enabled = true;
        }
        if (isFaceShieldEat)
        {
            itemFaceShield.enabled = true;
        }
        if (isElmoEat)
        {
            itemElmo.enabled = true;
            itemElmoExtraLife.enabled = true;
        }
        if (isAmbulanciaEat)
        {
            itemAmbulancia.enabled = true;
        }
        if (isVacina1Eat)
        {
            itemVacina1.enabled = true;
        }
        if (isVacina2Eat)
        {
            itemVacina2.enabled = true;
        }
    }
}