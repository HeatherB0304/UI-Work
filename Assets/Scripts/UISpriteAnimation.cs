using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISpriteAnimation : MonoBehaviour
{
    public Image m_Image;

    public Sprite[] m_SpriteArray;
    public float m_Speed = 0.2f;

    private int m_IndexSprite;
    Coroutine m_CoroutineAnim;
    bool IsDone;

    private void OnEnable()
    {
        StartAnimation();
    }

    private void OnDisable()
    {
        StopAnimation();
    }

    private void StartAnimation()
    {
        IsDone = false;
        m_CoroutineAnim = StartCoroutine(PlayAnim());
    }

    private void StopAnimation()
    {
        IsDone = true;
        StopCoroutine(m_CoroutineAnim);
    }

    IEnumerator PlayAnim()
    {
        while (!IsDone)
        {
            yield return new WaitForSeconds(m_Speed);
            if (m_IndexSprite >= m_SpriteArray.Length)
            {
                m_IndexSprite = 0;
            }
            m_Image.sprite = m_SpriteArray[m_IndexSprite];
            m_IndexSprite++;
        }
    }
}
