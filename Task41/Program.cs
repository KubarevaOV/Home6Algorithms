Random rnd = new Random();
int m  = rnd.Next(1, 11);
int counter = 0;

int[] array = new int[m];
Console.WriteLine("Введите {0} чисел", (m));

for (int i = 0; i<m; i++) {
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i<array.Length; i++) {
    if (array[i] > 0) {
        counter ++;
    }
}

Console.WriteLine("Вы ввели {0} чисел больше 0", counter);