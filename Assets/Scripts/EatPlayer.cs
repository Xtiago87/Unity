using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class EatPlayer : MonoBehaviour
{
    public string sceneName;

    public Transform target;
    AudioSource source;
    public AudioClip loseAudio;

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        source = GetComponent<AudioSource>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (transform.localScale.x > target.localScale.x && transform.localScale.y > target.localScale.y) {
            
            if (col.gameObject.tag == "Player")
        {
                Debug.Log("Morreu");
                //Destroy(col.gameObject);
                SceneManager.LoadScene("Death");
                source.PlayOneShot(loseAudio, 0.7F);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}