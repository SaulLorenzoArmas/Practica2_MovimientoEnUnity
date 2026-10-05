using UnityEngine;

public class Ejercicio6_Velocidad : MonoBehaviour {
    public float velocidad;
    void Update() {
        float valorHorizontal = Input.GetAxisRaw("Horizontal");
        float valorVertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            float result = velocidad * valorHorizontal;
            Debug.Log("Flecha izquierda: " + result);
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            float result = velocidad * valorHorizontal;
            Debug.Log("Flecha derecha: " + result);
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            float result = velocidad * valorVertical;
            Debug.Log("Flecha abajo: " + result);
        } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            float result = velocidad * valorVertical;
            Debug.Log("Flecha arriba: " + result);
        }
    }
}
