using TMPro;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public abstract class Shell : MonoBehaviour
{
    [SerializeField] float m_speed = 3f;
    [SerializeField] float m_lifeTime = 7f;

    //[SerializeField] AudioClip _sound = default;
    Rigidbody2D rb;
    Transform GT;

    public virtual void First()//ïKê{
    {
        rb = GetComponent<Rigidbody2D>();
        GT = GameObject.Find("Gun").GetComponent<Transform>();
        //AudioSource.PlayClipAtPoint(_sound, Camera.main.transform.position);
        
    }

    public virtual void DestroyTime()//ïKê{
    {
        Destroy(this.gameObject, m_lifeTime);
    }

    public virtual void Speed()//ïKê{
    {
        rb.velocity = Vector2.right * m_speed * GT.localScale.x;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Hit();
            Destroy(collision.gameObject);
        }
    }
    
    public virtual void Hit()
    {
        Destroy(this.gameObject);
    }

    public virtual void Penetrete()
    {

    }

    public virtual void Diffuse()
    {

    }
}