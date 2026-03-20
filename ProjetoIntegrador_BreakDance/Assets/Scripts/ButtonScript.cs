using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public GameManager gameManager;

    [Header("Botão")]
    [SerializeField] public Button[] buttons;

    [Header("Sprite")]
    [SerializeField] public Sprite[] sprites;

    

    void Start()
    {
        
       

    }


    void Update()
    {

     
        
      

    }

    public void Apertar(Button botao)
    {
        

        if (Input.touchCount == 1 && buttons[0])
        {
            
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[0];
            gameManager.GainPoints(1);
            
        }
        
    }

    public void Apertar2()
    {
        if (Input.touchCount == 1 && buttons[1])
        {
            
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[1];
            gameManager.GainPoints(5);

        }

    }

    public void Apertar3()
    {
        if (Input.touchCount == 1 && buttons[2])
        {
            
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[2];
            gameManager.GainPoints(5);

        }

    }

    public void Apertar4(Button botao)
    {
        if (Input.touchCount == 1 && buttons[3])
        {
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[3];
            gameManager.GainPoints(10);
        }
       
    }

}
