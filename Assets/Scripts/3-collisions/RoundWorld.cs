using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundWorld : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    public GameObject leftborder;
    public GameObject rightborder;
    public GameObject topborder;
    public GameObject bottomborder;
    float radius = 1f;
 
    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.tag == triggeringTag && enabled)
        {
            if (this.tag == "RightBorder")
            {
                other.gameObject.transform.position = new Vector3(leftborder.transform.position.x + radius, other.transform.position.y, other.transform.position.z);
            }
            if (this.tag == "LeftBorder")
            {
                other.gameObject.transform.position = new Vector3(rightborder.transform.position.x - radius, other.transform.position.y, other.transform.position.z);
            }
            if (this.tag == "TopBorder")
            {
                other.gameObject.transform.position = new Vector3(other.transform.position.x, bottomborder.transform.position.y + radius, other.transform.position.z);
            }
            if (this.tag == "BottomBorder")
            {
                other.gameObject.transform.position = new Vector3(other.transform.position.x, topborder.transform.position.y - radius, other.transform.position.z);
            }
        }
    }

}
