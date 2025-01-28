using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObjectBoundary : MonoBehaviour
{
    public Vector3 minBounds; // Oyun alan�n�n minimum s�n�rlar�
    public Vector3 maxBounds; // Oyun alan�n�n maksimum s�n�rlar�

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Nesnenin pozisyonunu kontrol et
        Vector3 clampedPosition = transform.position;

        // X ekseninde s�n�rland�rma
        clampedPosition.x = Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x);

        // Y ekseninde s�n�rland�rma
        clampedPosition.y = Mathf.Clamp(transform.position.y, minBounds.y, maxBounds.y);

        // Z ekseninde s�n�rland�rma
        clampedPosition.z = Mathf.Clamp(transform.position.z, minBounds.z, maxBounds.z);

        // S�n�r d���na ��kan nesneyi s�n�r i�ine geri �ek
        transform.position = clampedPosition;
    }
}
