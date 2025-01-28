using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObjectBoundary : MonoBehaviour
{
    public Vector3 minBounds; // Oyun alanýnýn minimum sýnýrlarý
    public Vector3 maxBounds; // Oyun alanýnýn maksimum sýnýrlarý

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Nesnenin pozisyonunu kontrol et
        Vector3 clampedPosition = transform.position;

        // X ekseninde sýnýrlandýrma
        clampedPosition.x = Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x);

        // Y ekseninde sýnýrlandýrma
        clampedPosition.y = Mathf.Clamp(transform.position.y, minBounds.y, maxBounds.y);

        // Z ekseninde sýnýrlandýrma
        clampedPosition.z = Mathf.Clamp(transform.position.z, minBounds.z, maxBounds.z);

        // Sýnýr dýþýna çýkan nesneyi sýnýr içine geri çek
        transform.position = clampedPosition;
    }
}
