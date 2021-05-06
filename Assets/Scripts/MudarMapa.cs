using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MudarMapa : MonoBehaviour
{
    
  public string faseParaCarregar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var renderer = gameObject.GetComponent<Renderer>();
        float x = renderer.bounds.size.x;
        float y = renderer.bounds.size.y;

        if (x >= 3 && y>= 3)
        //if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(faseParaCarregar);
        }

    }
}
