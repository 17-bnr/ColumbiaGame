using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpButton : MonoBehaviour
{
    public Button upb;
    public void UpClick(){
        Debug.Log("Press Start");
        if(GManager.instance.restart_flag==0){
            GManager.instance.restart_flag = 1;
            
            
            GManager.instance.player_num = 1;
            GManager.instance.text_mode = 1;
            
            Debug.Log("press up button");
        }
    }

    public void Active(){
        upb.interactable = true;
    }
    public void Inactive(){
        upb.interactable = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        upb = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

    }


}
