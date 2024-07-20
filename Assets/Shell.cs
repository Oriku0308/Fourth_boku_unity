using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public abstract class Shell : MonoBehaviour
{
    [SerializeField] public float m_speed = 3f;
    [SerializeField] float m_lifeTime = 7f;

    //[SerializeField] AudioClip _sound = default;
    public Rigidbody2D rb;
    public Transform gt;
    //íÖíeèàóùóp
    private int _hitCount = 0;
    [SerializeField] int _maxHit = 1;

    public virtual void First()//ïKê{
    {
        rb = GetComponent<Rigidbody2D>();
        gt = GameObject.Find("Gun").GetComponent<Transform>();
        //AudioSource.PlayClipAtPoint(_sound, Camera.main.transform.position);
    }

    public virtual void DestroyTime()//ïKê{
    {
        Destroy(this.gameObject, m_lifeTime);
    }

    public virtual void Speed()//ïKê{
    {
        rb.velocity = Vector2.right * m_speed * gt.localScale.x;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Hit();
            Destroy(collision.gameObject);
        }
    }

    public void Hit()
    {
        _hitCount++;
        if (_hitCount == _maxHit)
        {
            Destroy(this.gameObject);
        }
    }
}