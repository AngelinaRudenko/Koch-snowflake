Некоторые заметки по разработке

После того, как были нарисованы _. ._, стоит задача высчитать координату вершины равностороннего треугольника.

Геометрически задачу можно решить по крайней мере двумя способами:
1. Проводим окружности с радиусом, равным данной стороне (обозначим его 'a') и ищем точки их пересечения.
2. Находим середину заданной стороны, проводим через нее срединный перпендикуляр и откладываем на нем в обе стороны отрезки длины a*cos(60°) = a*sqrt(3)/2

Оба способа должны дать одинаковые формулы, но второй проще, так как не нужно решать уравнения. Итак имеем
cредняя точка -  (x1+x2)/2, (y1+y2)/2 
перпендикуляр -  y1-y2, x2-x1 ,
и искомые вершины 
(x1 + x2 +- (y1 - y2)*sqrt(3))/2, 
(y1 + y2 +- (x2 - x1)*sqrt(3))/2

Но более простой способ - переместить начало координат в одну из вершин, повернуть на 60 градусов и переместить назад. Тогда получится следующая формула:
x3=(x2-x1)*cos(60)-(y2-y1)*sin(60)+x1
y3=(x2-x1)*sin(60)+(y2-y1)*cos(60)+y1

https://www.programmersforum.ru/showthread.php?t=317832
https://www.cyberforum.ru/algorithms/thread420607.html

Нахождение середины отрезка: (x1 + x2) / 2
Нахождение 1/3 отрезка: (2 * x1 + x2) / 3
Нахождение 2/3 отрезка: (x1 + 2 * x2) / 3

У звездочки рисуются _ _ до тех пор, пока не останется последняя итерация, на которой нарисуется /\.