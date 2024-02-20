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
   | Файл | https://github.com/ksalikhova/TFLC/blob/master/README%20images/file_menu.png |
   | Правка  | https://github.com/ksalikhova/TFLC/blob/master/README%20images/correction_menu.png | 
   |Текст| https://github.com/ksalikhova/TFLC/blob/master/README%20images/text_menu.png |
   |Пуск| __ |
   |Справка| https://github.com/ksalikhova/TFLC/blob/master/README%20images/info_menu.png |
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
