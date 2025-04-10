   using UnityEngine;

   public class RandomColor : MonoBehaviour
   {
       private Renderer objRenderer;

       void Start()
       {
           // Получаем Renderer объекта
           objRenderer = GetComponent<Renderer>();
           
           // Генерируем случайный цвет
           Color randomColor = new Color(Random.value, Random.value, Random.value);
           
           // Применяем случайный цвет к материалу
           objRenderer.material.color = randomColor;
       }
   }
   
