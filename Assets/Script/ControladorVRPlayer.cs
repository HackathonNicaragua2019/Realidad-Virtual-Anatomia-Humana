using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Rigidbody))]

public class ControladorVRPlayer : MonoBehaviour
{

    private CharacterController ControladordelCuerpo;
    private Vector3 MovimientoEndireccion = Vector3.zero;
    private Vector2 entrada;

    private CollisionFlags Banderasdecollision;

    public float fuerzaaltocarelsuelo;
    public float multiplicarGravedad;

    // Start is called before the first frame update
    void Start()
    {
        ControladordelCuerpo = GetComponent<CharacterController>();
            
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 Movimientodeseado = transform.forward * entrada.y + transform.right * entrada.x;

        RaycastHit hitinfo;
        Physics.SphereCast(transform.position, ControladordelCuerpo.radius, Vector3.down, out hitinfo, ControladordelCuerpo.height / 2f, Physics.AllLayers, QueryTriggerInteraction.Ignore);

        Movimientodeseado = Vector3.ProjectOnPlane(Movimientodeseado, hitinfo.normal).normalized;

        if (ControladordelCuerpo.isGrounded)
        {
            Movimientodeseado.y = -fuerzaaltocarelsuelo;
        }
        else {
            MovimientoEndireccion += Physics.gravity * multiplicarGravedad * Time.fixedDeltaTime;
        }
        Banderasdecollision = ControladordelCuerpo.Move(MovimientoEndireccion * Time.fixedDeltaTime);
    }
}
