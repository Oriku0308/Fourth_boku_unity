using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    /// <summary>”wŒi</summary>
    [SerializeField] SpriteRenderer m_backgroundSprite = null;
    /// <summary>”wŒi‚ÌƒXƒNƒ[ƒ‹‘¬“x</summary>
    [SerializeField] float m_scrollSpeedX = -1f;
    /// <summary>”wŒi‚ğƒNƒ[ƒ“‚µ‚½‚à‚Ì‚ğ“ü‚ê‚Ä‚¨‚­•Ï”</summary>
    SpriteRenderer m_backgroundSpriteClone;
    /// <summary>”wŒiÀ•W‚Ì‰Šú’l</summary>
    float m_initialPositionX;

    void Start()
    {
        m_initialPositionX = m_backgroundSprite.transform.position.x;   // À•W‚Ì‰Šú’l‚ğ•Û‘¶‚µ‚Ä‚¨‚­

        // ”wŒi‰æ‘œ‚ğ•¡»‚µ‚Äã‚É•À‚×‚é
        m_backgroundSpriteClone = Instantiate(m_backgroundSprite);
        m_backgroundSpriteClone.transform.Translate(m_backgroundSprite.bounds.size.x, 0f, 0f);
    }

    void Update()
    {
        // ”wŒi‰æ‘œ‚ğƒXƒNƒ[ƒ‹‚·‚é
        m_backgroundSprite.transform.Translate(m_scrollSpeedX * Time.deltaTime, 0f , 0f);
        m_backgroundSpriteClone.transform.Translate(m_scrollSpeedX * Time.deltaTime, 0f , 0f);

        // ”wŒi‰æ‘œ‚ª‚ ‚é’ö“x‰º‚É~‚è‚½‚çAã‚É–ß‚·
        if (m_backgroundSprite.transform.position.x < m_initialPositionX - m_backgroundSprite.bounds.size.x)
        {
            m_backgroundSprite.transform.Translate(m_backgroundSprite.bounds.size.x * 2, 0f , 0f);
        }

        // ”wŒi‰æ‘œ‚ÌƒNƒ[ƒ“‚ª‚ ‚é’ö“x‰º‚É~‚è‚½‚çAã‚É–ß‚·
        if (m_backgroundSpriteClone.transform.position.x < m_initialPositionX - m_backgroundSpriteClone.bounds.size.x)
        {
            m_backgroundSpriteClone.transform.Translate(m_backgroundSpriteClone.bounds.size.x * 2, 0f , 0f);
        }
    }
}