using TMPro;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public abstract class Shell : MonoBehaviour
{
    [SerializeField] float m_speed = 3f;
    [SerializeField] float m_lifeTime = 7f;

    [SerializeField] AudioClip _sound = default;
    Rigidbody rb;
    Transform GT;

    public void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Transform GT = GameObject.Find("Gun").GetComponent<Transform>();
        AudioSource.PlayClipAtPoint(_sound, Camera.main.transform.position);
        Destroy(this.gameObject, m_lifeTime);
    }

    public virtual void Fire()//”­ŽË‘¬“x‚ð•Ï‚¦‚ç‚ê‚é
    {
        rb.velocity = Vector2.right * m_speed * GT.localScale.x;
    }

    public virtual void Hit()
    {
        Destroy(this);
    }

    public abstract void Penetrete();
}