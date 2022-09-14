using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//este script lo q hace es procesar el INPUT DEL USER, no maneja el swerve
public class SwerveInputController : MonoBehaviour
{
    //para el swerve, necesitamos establecer cuando el jugador pone el dedo en la pantlla, cuando mantiene el dedo, y cuando lo quita.
    private float _posicionDedoUltimoFrameX; //trackea la posición del dedo en el ultimo frame
    private float _movX; 
    public float MovX => _movX; //propiedad a la cual accederemos del scrip que hara el swerve
        private void Update() 
        {
            //lo q se hace es comparar la posición en donde está el dedo en el frame actual, con la posición dónde estaba en el último frame y encontrar el movimiento
            if (Input.GetMouseButtonDown(0)) //devuelve true cuando se toca la pantalla
            {     
                _posicionDedoUltimoFrameX = Input.mousePosition.x;

            }
            else if (Input.GetMouseButton(0)) //true cuando se mantiene
            {
                _movX = Input.mousePosition.x - _posicionDedoUltimoFrameX;  //cuanto se movio con respecto al último frame
                _posicionDedoUltimoFrameX = Input.mousePosition.x;  //se actualiza la ultima posición
                
                
            }
            else if (Input.GetMouseButtonUp(0)) //true cuando se saca el dedo
            {
                _movX = 0f; //sin el dedo en la pantalla, no se considera movimiento
             
            }


        

        }
}
