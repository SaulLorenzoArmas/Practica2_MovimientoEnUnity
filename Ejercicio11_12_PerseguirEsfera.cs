using UnityEngine;

public class Ejercicio11_PerseguirEsfera : MonoBehaviour {
    public float velocidad;
    private GameObject esferaEnemiga;
    void Start() {
      esferaEnemiga = GameObject.FindWithTag("Esferita");
    }
    void Update() {
      Vector3 vectorDistancia = esferaEnemiga.transform.position - transform.position;
      vectorDistancia.y = 0;
      // El normalized es para que la velocidad de movimiento del cubo sea "estable" 
      // y no vaya muy rapido cuando este lejos o lento cuando este cerca.
      transform.Translate(vectorDistancia.normalized * velocidad * Time.deltaTime, Space.World);
      // Se necesita que sea con respecto al mundo porque al girarte hacia el objetivo,
      // los ejes locales se descuadran.
      transform.LookAt(esferaEnemiga.transform);
    }
}
