using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidadMovimiento = 7.5f;
    public float fuerzaSalto = 12.0f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, v) * velocidadMovimiento * Time.deltaTime);
    }
}
