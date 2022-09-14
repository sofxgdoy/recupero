using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovimiento : MonoBehaviour
{
   
   private SwerveInputController _swerveInputController; // arrancamos referenciando el input
   [SerializeField] private float swerveVelocidad = 0.3f;
   
   private void Awake() 
   {
    _swerveInputController = GetComponent<SwerveInputController>(); //lo pedimos
   }
   
   private void Update()
   {
      
      float swerveAmount  = Time.deltaTime * swerveVelocidad * _swerveInputController.MovX;
    
      transform.Translate(swerveAmount, 0, 0);

      var pos = transform.position;
      pos.x = Mathf.Clamp(transform.position.x, -30.0f, 30.0f);
      transform.position=pos;
   }
}
