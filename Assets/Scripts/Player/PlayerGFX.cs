using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGFX : MonoBehaviour
{
    Vector2 mousePos;

    [SerializeField] private GameObject playerGFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mousePos.x = Input.GetAxisRaw("Mouse X");
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = new Vector2(
            mousePos.x - transform.position.x , mousePos.y - transform.position.y);

        if (direction.x >= 0.01f)
        {
            playerGFX.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (direction.x <= -0.01f)
        {
            playerGFX.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
}
