using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takamina : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    public Sprite syoubu;
    public Sprite up;
    public Sprite right;
    public Sprite down;
    public Sprite left;
    public Sprite normal;

    private int takamina_flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = normal;
    }

    // Update is called once per frame
    void Update()
    {
        if(GManager.instance.takamina_mode==2){
            MainSpriteRenderer.sprite = syoubu;
            takamina_flag = 1;
        }
        if(GManager.instance.takamina_mode==1){
            if(takamina_flag==1){
                GManager.instance.dealer_num = Random.Range(1,5);
                takamina_flag = 0;
            }
            
            
            switch (GManager.instance.dealer_num){
                case 1:
                  MainSpriteRenderer.sprite = up;
                  break;

                case 2:
                  MainSpriteRenderer.sprite = right;
                  break;

                case 3:
                  MainSpriteRenderer.sprite = down;
                  break;

                case 4:
                  MainSpriteRenderer.sprite = left;
                  break;
            }
        }if(GManager.instance.takamina_mode==0){
            MainSpriteRenderer.sprite = normal;
        }
    }
}
