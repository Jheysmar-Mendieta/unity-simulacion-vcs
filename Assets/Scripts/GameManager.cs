using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string versionSimulacion = "1.1.0-nivel1";
    public float gravedadNivel = -9.81f; // Gravedad estandar definida por diseño de nivel 1
    public int puntosObjetivo = 200;

    void Start()
    {
        Debug.Log("Iniciando Simulacion Unity en Escenario Nivel 1");
    }
}
