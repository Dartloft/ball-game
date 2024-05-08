using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HostManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jugar()
    {
       
        if(Input.GetKeyUp(KeyCode.A))
        {
            SceneManager.LoadScene("Game",LoadSceneMode.Single);
        }
            
        
    }

    public void Salir()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Application.Quit();
        }
    }
}
