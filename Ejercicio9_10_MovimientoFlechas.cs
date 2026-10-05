using UnityEngine;

public class Ejercicio9_MovimientoFlechas : MonoBehaviour {
  public float velocidad;
  void Update() {
    float desplazamientoVertical = Input.GetAxis("Vertical");
    float desplazamientoHorizontal = Input.GetAxis("Horizontal");
    if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {
      transform.Translate(new Vector3(desplazamientoHorizontal,desplazamientoVertical,0) * velocidad * Time.deltaTime);
    } 
  }
}
