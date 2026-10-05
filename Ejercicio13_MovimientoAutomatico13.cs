using UnityEngine;

public class Ejercicio13_MovimientoAutomatico13 : MonoBehaviour {
  public float velocidad;
  void Update() {
    float desplazamientoHorizontal = Input.GetAxis("Horizontal");
    transform.Translate(transform.forward * velocidad * Time.deltaTime, Space.World);
    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
      // Gira sobre el eje Y, cambiando la nariz del objeto, y como siempre se desplaza hacia donde apunte 
      // esa nariz, el objeto se moverá en la dirección que se le indique.
      float velocidadGiro = 90;
      transform.Rotate(new Vector3(0,velocidadGiro * desplazamientoHorizontal,0) * Time.deltaTime);
    } 
    // Desde el centro del objeto, dibuja un rayo hacia adelante de 5 metros de longitud y de color rojo.
    Debug.DrawRay(transform.position, transform.forward * 5, Color.red);
  }
}
