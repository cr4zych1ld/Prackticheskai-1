namespace Lib_4
{
    public class RandomNumberProces
    {
        public List<int> GenerateRandomNumbers(int count) // ����� ��� ��������� ������ ��������� ��������
        {
            Random rnd = new Random();

            List<int> numbers = new List<int>(); // ������������� ������ ��� �������� ��������� ��������

            for (int i = 0; i < count; i++)
            {
                numbers.Add(rnd.Next(10, 41));
            }

            return numbers;
        }

        public int GetMinimumValue(List<int> numbers) // ����� ��� ���������� ���. �������� � ������
        {
            int minValue = numbers[0]; // ������������� ������������ �������� ������ ��������� ������

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