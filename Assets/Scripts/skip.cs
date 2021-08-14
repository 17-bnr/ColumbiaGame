using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skip : MonoBehaviour
{
    private bool firstButton = false;
    public void PressStart(){
        Debug.Log("Press Start");
        if(!firstButton){
            Debug.Log("Go Next Scene!");
            SceneManager.LoadScene("Result");
            firstButton = true;
     
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
