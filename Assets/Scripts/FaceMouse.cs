using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class FaceMouse : MonoBehaviour
{
    Vector2 movement;
    public Rigidbody2D rb;
    public Vector2 flip;
    public SpriteRenderer renderer;

   void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        faceMouse();
    }

    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (mousePosition.x > gameObject.transform.parent.position.x)
        {
            gameObject.transform.localPosition = new Vector2(0.83f, -0.02f);
            renderer.flipY = false;
        }
        else
        {
            gameObject.transform.localPosition = new Vector2(-0.83f, -0.02f);
            renderer.flipY = true;
        }

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y);
        transform.right = direction;
    }    
}
