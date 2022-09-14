using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muteAudio : MonoBehaviour
{


    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    private bool isOn = true;

    public AudioSource audioSource;

    void Start(){
        soundOnImage = button.image.sprite; //toma la imagen del boton y la almacena

    }

    public void ClickBoton() {
        if (isOn)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            audioSource.mute = false;
        }
    }
}
