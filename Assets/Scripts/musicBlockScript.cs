using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class musicBlockScript : MonoBehaviour
{
    public AudioSource music;
    public Color blinkColor;
    public float transformTime = 0.5f;
    private SpriteRenderer spriteRenderer;
    private Color originColor;

    // Use this for initialization
    void Start()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();
        this.originColor = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayMusic()
    {
        music.Play();
        spriteRenderer.color = blinkColor;
        DOTween.To(() => spriteRenderer.color, x => spriteRenderer.color = x, this.originColor,  transformTime);
    }
}
