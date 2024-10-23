namespace Lib_4
{
    public class RandomNumberProces
    {
        public List<int> GenerateRandomNumbers(int count) // Метод для генерации списка случайных значений
        {
            Random rnd = new Random();

            List<int> numbers = new List<int>(); // Инициализация списка для хранения случайных значений

            for (int i = 0; i < count; i++)
            {
                numbers.Add(rnd.Next(10, 41));
            }

            return numbers;
        }

        public int GetMinimumValue(List<int> numbers) // Метод для нахождения мин. значения в списке
        {
            int minValue = numbers[0]; // Инициализация минимального значения первым элементом списка

            for (int i = 0; i < numbers.Count; i++) 
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
            }

            return minValue;
        }
    }
}