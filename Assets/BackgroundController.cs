using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    /// <summary>�w�i</summary>
    [SerializeField] SpriteRenderer m_backgroundSprite = null;
    /// <summary>�w�i�̃X�N���[�����x</summary>
    [SerializeField] float m_scrollSpeedX = -1f;
    /// <summary>�w�i���N���[���������̂����Ă����ϐ�</summary>
    SpriteRenderer m_backgroundSpriteClone;
    /// <summary>�w�i���W�̏����l</summary>
    float m_initialPositionX;

    void Start()
    {
        m_initialPositionX = m_backgroundSprite.transform.position.x;   // ���W�̏����l��ۑ����Ă���

        // �w�i�摜�𕡐����ď�ɕ��ׂ�
        m_backgroundSpriteClone = Instantiate(m_backgroundSprite);
        m_backgroundSpriteClone.transform.Translate(m_backgroundSprite.bounds.size.x, 0f, 0f);
    }

    void Update()
    {
        // �w�i�摜���X�N���[������
        m_backgroundSprite.transform.Translate(m_scrollSpeedX * Time.deltaTime, 0f , 0f);
        m_backgroundSpriteClone.transform.Translate(m_scrollSpeedX * Time.deltaTime, 0f , 0f);

        // �w�i�摜��������x���ɍ~�肽��A��ɖ߂�
        if (m_backgroundSprite.transform.position.x < m_initialPositionX - m_backgroundSprite.bounds.size.x)
        {
            m_backgroundSprite.transform.Translate(m_backgroundSprite.bounds.size.x * 2, 0f , 0f);
        }

        // �w�i�摜�̃N���[����������x���ɍ~�肽��A��ɖ߂�
        if (m_backgroundSpriteClone.transform.position.x < m_initialPositionX - m_backgroundSpriteClone.bounds.size.x)
        {
            m_backgroundSpriteClone.transform.Translate(m_backgroundSpriteClone.bounds.size.x * 2, 0f , 0f);
        }
    }
}