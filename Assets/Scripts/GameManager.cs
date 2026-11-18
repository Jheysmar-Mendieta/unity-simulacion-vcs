using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string versionSimulacion = "1.2.0-release";
    public float gravedadNivel = -12.5f; // Valor consensuado entre Programador y Diseñador Nivel 1
    public int puntosObjetivo = 200;

    void Start()
    {
        Debug.Log("Iniciando Simulacion Unity: Jugador + Escenario Nivel 1 Integrados");
    }
}
