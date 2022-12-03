using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    private bool _isPackagePickedUp = false;
    [SerializeField] private float destroyDelay = 0.5f;
    [SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1, 1);
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision with vehicle");
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag.Equals("Package") && !_isPackagePickedUp)
        {
            _isPackagePickedUp = true;
            _spriteRenderer.color = hasPackageColor;
            Debug.Log("Package picked up");
            Destroy(other.gameObject,destroyDelay);
        }

        if (other.tag.Equals("Customer") && _isPackagePickedUp)
        {
            _isPackagePickedUp = false;
            _spriteRenderer.color = noPackageColor;
            Debug.Log("Package delivered");
        }
        
    }
    
}