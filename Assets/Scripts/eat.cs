using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class eat : MonoBehaviour
{

    public float Increase;
    public float Decrease;
    public float Speed;

    public float power = 1;
    public float powerTimeR = 0;
    public float timePassedR = 0;
    public float powerTimeE = 0;
    public float extraLife = 0;

    bool isEvaEat = false;
    bool isVacina1Eat = false;
    bool isVacina2Eat = false;
    bool isMascaraCEat = false;
    bool isMascaraPEat = false;
    bool isAlcoolEat = false;
    bool isFaceShieldEat = false;
    bool isRespiradorEat = false;
    bool isElmoEat = false;
    bool isAmbulanciaEat = false;

    float evaEatCont = 0;
    float vacina1EatCont = 0;
    float vacina2EatCont = 0;
    float mascaraCEatCont = 0;
    float mascaraPEatCont = 0;
    float alcoolEatCont = 0;
    float faceShieldEatCont = 0;
    float respiradorEatCont = 0;
    float elmoEatCont = 0;
    float ambulanciaEatCont = 0;

    public string sceneName;

    public Text scoreText;
    public static int score;

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
    
    public GameObject pauseMenu;
    public GameObject evaPause;
    public GameObject mascaraCPause;
    public GameObject mascaraPPause;
    public GameObject alcoolPause;
    public GameObject faceShieldPause;
    public GameObject respiradorPause;
    public GameObject elmoPause;
    public GameObject ambulanciaPause;
    public GameObject vacina1Pause;
    public GameObject vacina2Pause;

    AudioSource source;
    public AudioClip clickButtonAudio;
    public AudioClip loseAudio;
    public AudioClip winAudio;

    public Transform explosion;

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
            transform.localScale += new Vector3(0.1f * power, 0.1f * power); // +10 power
            Destroy(col.gameObject);
             source.PlayOneShot(clickButtonAudio, 0.7F);
            Camera.main.orthographicSize += 0.5f * power;
            AddPoint(10);
            isMascaraCEat = true;
            mascaraCEatCont++;
        }
        else if (col.gameObject.tag == "MascaraP")
        {
source.PlayOneShot(clickButtonAudio, 0.7F);
            transform.localScale += new Vector3(0.2f * power, 0.2f * power); // +20 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.75f * power;
            AddPoint(20);
            isMascaraPEat = true;
            mascaraPEatCont++;
        }
        else if (col.gameObject.tag == "Alcool")
        {
source.PlayOneShot(clickButtonAudio, 0.7F);
            transform.localScale += new Vector3(0.01f * power, 0.01f) * power; // +1 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.25f * power;
            AddPoint(1);
            isAlcoolEat = true;
            alcoolEatCont++;
        }
        else if (col.gameObject.tag == "FaceShield")
        {
source.PlayOneShot(clickButtonAudio, 0.7F);
            transform.localScale += new Vector3(0.2f * power, 0.2f * power); // +20 power
            Destroy(col.gameObject);
            Camera.main.orthographicSize += 0.75f * power;
            AddPoint(20);
            isFaceShieldEat = true;
            faceShieldEatCont++;
        }
        else if (col.gameObject.tag == "Respirador")
        {
source.PlayOneShot(clickButtonAudio, 0.7F);
            Destroy(col.gameObject);
            isRespiradorEat = true;
            Camera.main.orthographicSize += 1f * power;
            isRespiradorEat = true;
            respiradorEatCont++;
        }
        else if (col.gameObject.tag == "Elmo")
        {
            source.PlayOneShot(clickButtonAudio, 0.7F);
            extraLife++;
            Destroy(col.gameObject);
            isElmoEat = true;
            elmoEatCont++;
        }
        else if (col.gameObject.tag == "Eva")
        {
            source.PlayOneShot(clickButtonAudio, 0.7F);
            Destroy(col.gameObject);
            isEvaEat = true;
            power = 2;
            Speed = Speed * 1.5f;
            evaEatCont++;
        }
        else if (col.gameObject.tag == "Ambulancia")
        {
            Speed += 2;
source.PlayOneShot(clickButtonAudio, 0.7F);
            Destroy(col.gameObject);
            isAmbulanciaEat = true;
            ambulanciaEatCont++;
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
            vacina1EatCont++;
        }
        else if (col.gameObject.tag == "Vacina2")
        {
            source.PlayOneShot(clickButtonAudio, 0.7F);
            isVacina2Eat = true;
            Destroy(col.gameObject);
            vacina2EatCont++;
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
            if (x >= 20 && y >= 20)
            {
                source.PlayOneShot(winAudio, 0.7F);
                Debug.Log("Vacinado");
                SceneManager.LoadScene("Ceara");
            }
        }
        if (sceneName == "Ceara")
        {
            if (x >= 22.5 && y >= 22.5 && isVacina1Eat == true)
            {
                 source.PlayOneShot(winAudio, 0.7F);
                SceneManager.LoadScene("Brasil");
            }
        }
        if (sceneName == "Brasil" && isVacina2Eat == true)
        {
            if (x >= 22.5 && y >= 22.5)
            {
                 source.PlayOneShot(winAudio, 0.7F);
                SceneManager.LoadScene("Mundo");
            }
        }
        if (sceneName == "Mundo")
        {
            if (x >= 50 && y >= 50)
            {
                 source.PlayOneShot(winAudio, 0.7F);
                //SceneManager.LoadScene("");
            }
        }

        // if(GameObject.FindGameObjectWithTag("teste").GetComponent<Transform>() != null){
        //   target = GameObject.FindGameObjectWithTag("teste").GetComponent<Transform>();
        //     }

        if (faceShieldEatCont == 1)
        {
            PauseGame("faceShieldEat");
        }
        if (evaEatCont == 1)
        {
            PauseGame("evaEat");
        }
        if (vacina1EatCont == 1)
        {
            PauseGame("vacina1Eat");
        }
        if (vacina2EatCont == 1)
        {
            PauseGame("vacina2Eat");
        }
        if (mascaraCEatCont == 1)
        {
            PauseGame("mascaraCEat");
        } 
        if (mascaraPEatCont == 1)
        {
            PauseGame("mascaraPEat");
        } 
        if (alcoolEatCont == 1)
        {
            PauseGame("alcoolEat");
        }
        if (respiradorEatCont == 1)
        {
            PauseGame("respiradorEat");
        }
        if (elmoEatCont == 1)
        {
            PauseGame("elmoEat");
        }
        if (ambulanciaEatCont == 1)
        {
            PauseGame("ambulanciaEat");
        }

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

    void PauseGame(string text)
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);

        alcoolPause.SetActive(false);
        respiradorPause.SetActive(false);
        mascaraCPause.SetActive(false);
        faceShieldPause.SetActive(false);
        evaPause.SetActive(false);
        ambulanciaPause.SetActive(false);
        mascaraPPause.SetActive(false);

        if (text == "faceShieldEat") {
            faceShieldPause.SetActive(true);
        }
        if (text == "evaEat") {
            evaPause.SetActive(true);
        }
        if (text == "vacina1Eat") {
            vacina1Pause.SetActive(true);
        }
        if (text == "vacina2Eat") {
            vacina2Pause.SetActive(true);
        }
        if (text == "mascaraCEat") {
            mascaraCPause.SetActive(true);
        }
        if (text == "mascaraPEat") {
            mascaraPPause.SetActive(true);
        }
        if (text == "alcoolEat") {
            alcoolPause.SetActive(true);
        }
        if (text == "respiradorEat") {
            respiradorPause.SetActive(true);
        }
        if (text == "elmoEat") {
            elmoPause.SetActive(true);
        }
        if (text == "ambulanciaEat") {
            ambulanciaPause.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);

        if (isFaceShieldEat)
        {
            faceShieldEatCont++;
        }
        if (isEvaEat)
        {
            evaEatCont++;
        }
        if (isVacina1Eat)
        {
            vacina1EatCont++;
        }
        if (isVacina2Eat)
        {
            vacina2EatCont++;
        }
        if (isMascaraCEat)
        {
            mascaraCEatCont++;
        }
        if (isMascaraPEat)
        {
            mascaraPEatCont++;
        }
        if (isAlcoolEat)
        {
            alcoolEatCont++;
        }
        if (isRespiradorEat)
        {
            respiradorEatCont++;
        }
        if (isElmoEat)
        {
            elmoEatCont++;
        }
        if (isAmbulanciaEat)
        {
            ambulanciaEatCont++;
        }
    }
}