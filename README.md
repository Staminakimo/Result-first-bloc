**Задача:**
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


**Решение:**
 1. Объявляется два массива.
 Исходный массив- sourceArray и Новый массив-newArray, куда будем сохранять строки длина меньше, либо равна 3 символам (такой же длины, что и исходный массив).
 2. Пишем метод, где цикл проходится по всей длине массива, внутри цикла идет проверка условия, где лина строки больше или равна 3-м символам.
 3. если условие выполняется, то заносим строку в новый массив newArray.
 При этом используем переменная count для поочередного перекидывания строки из массива sourceArray в массив newArray, при этом исключаем пробелы. 
 4. Переменная count увеличивается на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца.