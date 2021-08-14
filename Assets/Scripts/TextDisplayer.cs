using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextDisplayer : MonoBehaviour
{
    private Text message_text = null;
    private int victory_flag = 0;
    private int takamina_flag = 0;

    private int oonisi_flag = 0;

    UpButton up;
    RightButton right;
    DownButton down;
    LeftButton left;

    // Start is called before the first frame update
    void Start()
    {
        message_text = GetComponent<Text>();
        up = GameObject.Find("UpButton").GetComponent<UpButton>();
        right = GameObject.Find("RightButton").GetComponent<RightButton>();
        down = GameObject.Find("DownButton").GetComponent<DownButton>();
        left = GameObject.Find("LeftButton").GetComponent<LeftButton>();
        if(GManager.instance!=null){
            takamina_flag = Random.Range(0,2);
            if(takamina_flag==0){
                oonisi_flag = 1;
            }else
            {
                oonisi_flag = 0;
            }
            if(takamina_flag==1){
                GManager.instance.takamina_mode=2;
            }
            if(oonisi_flag==1){
                GManager.instance.oonisi_mode=2;
            }
            message_text.text = "勝負だ！";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GManager.instance.text_mode==1){
            StartCoroutine(TextDisplay());
        }else{
            //StopCoroutine(TextDisplay());
        }
        if(GManager.instance.text_mode==2){
            StartCoroutine(ColumbiaDisplay());
        }
        if(GManager.instance.text_mode==3){
            StartCoroutine(ResultDisplay());
        }else{
            StopCoroutine(ResultDisplay());
        }
        if(GManager.instance.text_mode==4){
            StartCoroutine(ToResult());
        }
        if(GManager.instance.text_mode==5){
            StartCoroutine(Restart());
        }
    }

    private IEnumerator TextDisplay(){
        if(GManager.instance.player_num!=0){
            up.Inactive();
            right.Inactive();
            down.Inactive();
            left.Inactive();
            message_text.text = "せーの！";
            yield return new WaitForSeconds(2);
            
            
            GManager.instance.text_mode=2;
            if(takamina_flag==1){
                GManager.instance.takamina_mode = 1;
                
                takamina_flag = 0;
            }
            if(oonisi_flag==1){
                
                GManager.instance.oonisi_mode = 1;
                oonisi_flag = 0;
            }
                  
        }
    }

    private IEnumerator ColumbiaDisplay(){
         
         message_text.text = "コロンビア！";
         
         yield return new WaitForSeconds(2);
         GManager.instance.text_mode = 3;
    }
    private IEnumerator ResultDisplay(){
        if(victory_flag==1){
            GManager.instance.victory_count++;
            victory_flag = 0;
        }
        yield return new WaitForSeconds(2);
         if(GManager.instance.player_num==GManager.instance.dealer_num){
            message_text.text = "LOSE!!";
            GManager.instance.text_mode = 4;
         }else{
            message_text.text = "Draw";
            GManager.instance.text_mode = 5;
         }
    }

    private IEnumerator ToResult(){
        yield return new WaitForSeconds(2);
        GameObject.Find("GManager").GetComponent<GManager>().GameOver(GManager.instance.victory_count.ToString("F0") + "回");
    }

    private IEnumerator Restart(){
        yield return new WaitForSeconds(2);
        GManager.instance.player_num = 0;
        message_text.text = "勝負だ！";
        if(GManager.instance.takamina_mode==1){
            oonisi_flag = 1;
            GManager.instance.takamina_mode = 0;
            GManager.instance.oonisi_mode = 2;
        }
        if(GManager.instance.oonisi_mode==1){
            takamina_flag = 1;
            GManager.instance.oonisi_mode = 0;
            GManager.instance.takamina_mode = 2;
        }
        GManager.instance.text_mode = 0;
        yield return new WaitForSeconds(2);
        GManager.instance.restart_flag = 0;
        up.Active();
        right.Active();
        down.Active();
        left.Active();
        victory_flag = 1;
    }
}
