using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string versionSimulacion = "1.1.0-jugador";
    public float gravedadNivel = -15.0f; // Ajuste de fisica del programador para salto rapido
    public int puntosObjetivo = 150;

    void Start()
    {
        Debug.Log("Iniciando Simulacion Unity con Controlador de Jugador Activo");
    }
}
