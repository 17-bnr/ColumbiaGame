using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftButton : MonoBehaviour
{
    public Button leftb;

    // Start is called before the first frame update
    void Start()
    {
        leftb = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick(){
        if(GManager.instance.restart_flag==0){
            GManager.instance.restart_flag = 1;
            
            
            GManager.instance.player_num = 4;
            GManager.instance.text_mode = 1;
            
            Debug.Log("press up button");
        }
    }

    public void Active(){
        leftb.interactable = true;
    }

    public void Inactive(){
        leftb.interactable = false;
    }
}
