# **Компилятор**

Разработка текстового редактора с функциями языкового процессора.

## Оглавление
+ [Лабораторная работа №1 "Разработка пользовательского интерфейса (GUI) для языкового процессора"]()
+ [Лабороторная работа №2 "Разработка лексического анализатора (сканера)"]()
+ [Лабороторная работа №3 "Разработка синтаксического анализатора (парсера)"]()
+ [Лабороторная работа №4 "Нейтрализация ошибок (метод Айронса)"]()
+ [Лабороторная работа №5 "Включение семантики в анализатор. Создание внутренней формы представления программы"]()
+ [Лабороторная работа №6 "Реализация алгоритма поиска подстрок с помощью регулярных выражений"]()
+ [Лабороторная работа №7 "Реализация метода рекурсивного спуска для синтаксического анализа"]()
  
  ___

## Лабораторная работа №1 "Разработка пользовательского интерфейса (GUI) для языкового процессора"

**Тема:** разработка текстового редактора с возможностью дальнейшего расширения функционала до языкового процессора.

**Цель работы:** разработать приложение с графическим интерфейсом пользователя, способное редактировать текстовые данные. Это приложение будет базой для будущего расширения функционала в виде языкового процессора.

**Язык реализации:** C#.
### Интерфейс текстового редактора
![Главное окно программы](https://github.com/ksalikhova/TFLC/blob/master/README%20images/program_interface.PNG)
#### **Элементы текстового редактора:**
1. **Меню**
   | Пункт меню | Подпункты меню |
   | ------------- |   ------------- |
   | Файл | ![Файловые операции](https://github.com/ksalikhova/TFLC/blob/master/README%20images/file_menu.png) |
   | Правка  | ![Операции правки](https://github.com/ksalikhova/TFLC/blob/master/README%20images/correction_menu.png) | 
   |Текст| ![Операции текста](https://github.com/ksalikhova/TFLC/blob/master/README%20images/text_menu.png) |
   |Пуск| __ |
   |Справка| ![Операции справки](https://github.com/ksalikhova/TFLC/blob/master/README%20images/info_menu.png) |
2. **Панель инструментов**
   + Создать
   + Открыть
   + Сохранить
   + Отменить
   + Повторить
   + Копировать
   + Вырезать
   + Вставить
   + Пуск
   + Вызов справки
   + О программе
   + Увеличить размер текста
   + Уменьшить размер текста
  3. **Область редактирования**  
    Область для ввода текста. При открытии файла отображает текст из него.
  4. **Область отображения результатов**  
    Область отображения результатов выводит сообщения и результаты работы языкового процессора.
#### **Справка**
| Подпункт | Содержание |
   | ------------- |   ------------- |
   | Вызов справки | ![Содержимое веб-страницы справки](https://github.com/ksalikhova/TFLC/blob/master/README%20images/file_menu.png) |
   | О программе  | ![Содержимое окна "О программе"](https://github.com/ksalikhova/TFLC/blob/master/README%20images/program_info.png) | 
     
  ___


   ## Лабораторная работа №2 "Разработка лексического анализатора (сканера)"

**Тема:** разработка текстового редактора с возможностью дальнейшего расширения функционала до языкового процессора.

**Цель работы:** Изучить назначение лексического анализатора. Спроектировать алгоритм и выполнить программную реализацию сканера.

**В соответствии с вариантом задания необходимо:**
1. Спроектировать диаграмму состояний сканера (примеры диаграмм представлены в прикрепленных файлах).
2. Разработать лексический анализатор, позволяющий выделить в тексте лексемы, иные символы считать недопустимыми (выводить ошибку).
3. Встроить сканер в ранее разработанный интерфейс текстового редактора. Учесть, что текст для разбора может состоять из множества строк.

Входные данные - строка (текст программного кода).
Выходные данные - последовательность условных кодов, описывающих структуру разбираемого текста с указанием места положения и типа ("число", "идентификатор", "знак", "недопустимый символ" и т.д.).

| <!-- -->             | <!-- -->                                                   |
|:--------------------:|:----------------------------------------------------------:|
| №                    | 4                                                          | 
| Тема                 | Объявление комплексного числа с инициализацией на языке C# | 
| Пример верной строки | ```                                                        |
|                      |  Complex c1 = new Complex(1.2, 6.0);                       |
|                      | ```                                                        |

 **Язык реализации:** C#.
### Интерфейс текстового редактора
![Главное окно программы](https://github.com/ksalikhova/TFLC/blob/master/README%20images/program_interface.PNG)

