using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePhysics : MonoBehaviour
{
    Vector3 m_Velocity;
    Vector3 m_Acceleration;

    // Start is called before the first frame update
    void Start()
    {
        m_Velocity = new Vector3(1f, 1f, 0f);
        m_Acceleration = new Vector3(0f, -0.3f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        m_Velocity += m_Acceleration * Time.deltaTime;
        transform.position += m_Velocity * Time.deltaTime; 
    }
}
