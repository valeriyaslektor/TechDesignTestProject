using UnityEngine;

public class GhostClickHandler : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    public ParticleSystem vfx;

    private bool isClicking = false;

    void OnMouseDown()
    {
        isClicking = !isClicking;
        animator.SetBool("is_clicking", isClicking);

        if (isClicking)
        {
            audioSource.Play();
            if (vfx != null)
            {
                vfx.gameObject.SetActive(true);
                vfx.Play();
            }
        }
        else
        {
            audioSource.Stop();
            if (vfx != null)
            {
                vfx.Stop();
                vfx.Clear();
            }
        }
    }
}







