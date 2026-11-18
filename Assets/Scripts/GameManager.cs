using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string versionSimulacion = "1.0.0";
    public float gravedadNivel = -9.81f;
    public int puntosObjetivo = 100;

    void Start()
    {
        Debug.Log("Iniciando Simulacion Unity - Unica Fuente de Verdad");
    }
}
