using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonSonido : MonoBehaviour
{
    private SoundManager soundManager;
    void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClick(){
        soundManager.SeleccionAudio(0, 1f);
        Debug.Log("OnClick");

    }
}
