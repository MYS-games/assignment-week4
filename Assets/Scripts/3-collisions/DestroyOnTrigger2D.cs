using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    public TextMeshProUGUI textMeshPro;

    [SerializeField] 
    int life = 3;

    private void Start()
    {
        if (textMeshPro != null)
        {
            textMeshPro.SetText(life.ToString());
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (this.tag == "Player" && other.tag == triggeringTag)
        {
            life--;
            textMeshPro.SetText(life.ToString());
            if (life == 0)
            {
                Destroy(this.gameObject);
            } 
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.tag == triggeringTag && enabled) {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
