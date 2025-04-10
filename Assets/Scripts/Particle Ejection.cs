using UnityEngine;

public class ParticleOnCollision : MonoBehaviour
{
    public ParticleSystem particleSystem; // Ссылка на вашу систему частиц
    private bool hasCollided = false; // Флаг для проверки столкновения
    private int collisionCount = 0; // Переменная для подсчета количества столкновений

    void OnCollisionEnter(Collision collision)
    {
        if (collisionCount < 2)
        {
            // Запускаем систему частиц
            particleSystem.Play();
            hasCollided = true;
        }

        // Увеличиваем счётчик столкновений
        collisionCount++;
        Debug.Log("Количество столкновений: " + collisionCount);
    }
}
