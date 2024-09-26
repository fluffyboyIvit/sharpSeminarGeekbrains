// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)


int[] array = {2,3,1,7,5,6,3};
int[] array2 = new int[array.Length /2];

int right = array.Length - 1;
int left = 0;
while(left<right)
{
    array2[left] = array[left] * array[right];
    left++;
    right--;
}
for(int k=0 ; k <array2.Length;k++)
{  
    Console.Write($"{array2[k]} ");
}
