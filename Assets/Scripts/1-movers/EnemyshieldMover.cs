using UnityEngine;


public class EnemyshieldMover : MonoBehaviour
{
    [Tooltip("The speed of the horizontal objects's spowner")]
    [SerializeField] float speed = 1f;

    float scale;
    float top;
    float bottom;
    float indicator = 1f;

    private void Start()
    {
        scale = (Camera.main.pixelHeight * Time.deltaTime) / 2;
        top = transform.position.y + scale; 
        bottom = transform.position.y - scale;
    }
    
    void Update()
    {
        if (transform.position.y >= top)
        {

            indicator = -1;

        }
        if (transform.position.y <= bottom)
        {
         
            indicator = 1;
        }
        transform.position += new Vector3(0, indicator * speed * Time.deltaTime, 0);
    }
}
