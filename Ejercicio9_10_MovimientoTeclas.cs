using UnityEngine;

public class Ejercicio9_MovimientoTeclas : MonoBehaviour {
  public float velocidad;
  void Update() {
    float desplazamientoVertical = Input.GetAxis("Vertical");
    float desplazamientoHorizontal = Input.GetAxis("Horizontal");
    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) {
      transform.Translate(new Vector3(desplazamientoHorizontal,desplazamientoVertical,0) * velocidad * Time.deltaTime);
    } 
  }
}
