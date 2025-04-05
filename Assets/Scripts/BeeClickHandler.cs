using UnityEngine;

public class BeeClickHandler : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    public ParticleSystem vfx;

    private bool isFlying = false;

    void OnMouseDown()
    {
        isFlying = !isFlying;
        animator.SetBool("isFlying", isFlying);

        if (isFlying)
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










