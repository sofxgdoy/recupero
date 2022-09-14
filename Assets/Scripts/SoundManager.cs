using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] audios; //array q contendrá todos los audios
    private AudioSource controlAudio;
    //private SoundManager soundManager//

    private void Awake()
    {
        controlAudio = GetComponent<AudioSource>();
    }

    public void SeleccionAudio (int índice, float volumen){
        controlAudio.PlayOneShot(audios[índice], volumen);
    }


}
