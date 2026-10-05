using UnityEngine;

public class Ejercicio8_MoverDireccion : MonoBehaviour {
  public Vector3 moverDireccion;
  public float velocidad;
  void Start() {
    transform.position = new Vector3(1,0,0);
  }
  void Update() {
    transform.Translate(moverDireccion * velocidad * Time.deltaTime, Space.World); // El delta time es para que no salga disparado segun el ordenador.
  }
}
