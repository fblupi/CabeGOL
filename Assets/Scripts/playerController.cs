using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	//Velocidad máxima a la que se desplazará la nave.
	public float maxSpeed = 5f;
	
	//FixedUpdate es la función recomendada en la que hacer cambios que afecten al motor de física
	void FixedUpdate()
	{
		//Obtenemos los valores de nuestro "input" (-1.0f -> 1.0f)
		float moveX = Input.GetAxis ("Horizontal");
		
		//Proporcionamos estos valores al rigidbody2D como velocidad
		rigidbody2D.velocity = new Vector2 (moveX * maxSpeed, 0);
	}
}
