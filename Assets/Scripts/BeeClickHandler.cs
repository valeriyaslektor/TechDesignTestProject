using UnityEngine;

public class BeeClickHandler : MonoBehaviour
{
    public Animator animator; // Animator для управления анимацией пчелы
    public AudioSource audioSource; // Источник звука для воспроизведения звукового эффекта
    public ParticleSystem vfx; // Система частиц для визуальных эффектов

    private bool isFlying = false; // Флаг, указывающий, находится ли пчела в полете

    void OnMouseDown()
    {
        isFlying = !isFlying; // Переключаем состояние полета
        animator.SetBool("isFlying", isFlying); // Устанавливаем значение параметра анимации

        if (isFlying)
        {
            audioSource.Play(); // Воспроизводим звук, если пчела летит
            if (vfx != null)
            {
                vfx.gameObject.SetActive(true); // Активируем систему частиц
                vfx.Play(); // Запускаем анимацию частиц
            }
        }
        else
        {
            audioSource.Stop(); // Останавливаем звук, если пчела не летит
            if (vfx != null)
            {
                vfx.Stop(); // Останавливаем систему частиц
                vfx.Clear(); // Очищаем частицы
            }
        }
    }
}











