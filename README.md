## **Итоговая контрольная работа по основному блоку**

### **Задача:**

 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]*
[“Russia”, “Denmark”, “Kazan”] → []


## **Решение**

1. Первым делом написал саму структуру кода. То есть последовательность комманд и вызовов методов (с 1 по 5 строчки)
2. Далее с создал уже привычный мне метод PrintArray, чтобы в дальнейшем с помощью него я мог выводить одномерные массивы в консоль. В данном методе я использовал команду Console.Write(), а не Console.WriteLine(), так как мне важно было после вывода массива в консоль оставаться на той же строке, для того, чтобы результат вывода оформить как в примере к заданию.
3. Следующим шагом я создал метод GetUserArrayString, который будет создавать новый массив строк, введенных пользователем. В качестве аргумента метод принимает значение длины создаваемого массива.   
 * В теле метода я сперва создаю пустой массив (с длиной, которую я указал в аргументе).
 * Далее создаю цикл for в котором я пробегаюсь по каждому элементу массива и на каждой итерации я вывожу в консоль запрос у пользователя ввести данные.
 * Далее я возвращаю заполненный пользователем новый массив.
4. Следующим шагом я создал метод GetArrayNewString, который будет создавать новый массив из массива строк, длина которых меньше, либо равна 3 символам. В качестве аргумента метод принимает массив строк.
 * В теле метода я сперва определяю длину создаваемого массива. Для этого я создаю переменную int stringCount = 0, пробегаюсь циклом for по исходному массиву (корорый в аргументе метода) и на каждой итерации с помощью оператора if проверяю, является ли строка <= 3. Если является, то увеличиваю переменную stringCount на единицу. Таким образом я выясняю сколько элементов в исходном массиве соответствует условию и какой длины мне нужно создать новый массив.
 * Далее я создаю новый массив, длину которого я выяснил выше. 
 * Далее я создаю переменную int newArrayIndex = 0, которая будет являться индексом для нового массива. Циклом for я пробегаюсь по исходному массиву (корорый в аргументе метода) и на каждой итерации с помощью оператора if проверяю, является ли строка <= 3.  Если является, то присваеваю новому массиву в ячейку с индексом == newArrayIndex значение из ячейки i исходного массива, после чего увеличиваю newArrayIndex на единицу.
 * Далее возвращаю заполненный новый масссив.
 5. С помощью команды dotnet run запускаю программу в консоли и убеждаюсь что программа работает и задача решена.
