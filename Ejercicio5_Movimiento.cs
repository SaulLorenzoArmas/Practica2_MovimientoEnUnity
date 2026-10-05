using UnityEngine;

public class Ejercicio5_Movimiento : MonoBehaviour {
	public Vector3 desplazamiento;
	void Start() {}
	void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			transform.Translate(desplazamiento);
		}
	}
}
