# <b>Home work3

Тема: TCP и UDP сокеты. Часть 1</b><br>
#

Задание 1.<br>

Создайте серверное приложение «Курс валют» и клиентское для получения информации. Клиентское приложение подсоединяется к серверу, посылает сообщение с названием двух валют. Сервер возвращает курс одной валюты по отношению к другой. Например, если клиент послал: USD EURO (сервер должен вернуть соотношение доллара к евро, сколько евро дают за один доллар).<br>
Или EURO USD (сервер должен вернуть соотношение евро к доллару, сколько долларов дают за один евро).<br>
Клиент может запрашивать курсы валют, до тех пор, пока не решит отсоединиться. К одному серверу в один момент времени может быть подключено большое количество клиентов.<br>
Сервер ведет лог соединений:<br>
<ul>
<li>Кто подключился;</li>
<li>Когда подключился;</li>
<li>Курсы валют;</li>
<li>Время отключения.</li>
</ul>
Клиентское приложение отображает пользователю полученную информацию. Архитектура вашего приложения должна быть построена без привязки сетевой части к UI. Это означает, что сетевой блок кода может быть легко перемещен в любой вид приложения: консольное, оконное.<br>

<br>
Задание 2.<br><br>

Добавьте к первому заданию ограничение по максимальному количеству запросов для пользователя. Когда количество достигнуто, сервер сообщает клиенту об этом и рвёт соединение. Следующая сессия будет возможна через минуту. Максимальное количество запросов настраивается в интерфейсе сервера. Конкретная реализация остаётся за вами.<br>


Задание 3.<br>

Добавьте к первому заданию ограничение на максимальное количество подключенных клиентов. Когда количество достигнуто, при попытке нового подключения сервер сообщает клиенту, что сервер сейчас находится под максимальной нагрузкой и необходимо попробовать подключиться через какое-то время. Максимальное количество соединений настраивается в интерфейсе сервера. Конкретная реализация остаётся за вами.<br>

Задание 4.<br>

Добавьте к первому заданию пароль и имя пользователя для подключения. Если пароль и имя пользователя неизвестны, клиент подключиться не может. Логины и пароли добавляются через интерфейс сервера. Конкретная реализация остаётся за вами.<br>


# 

<b>Примечание</b><br>

Не получилось (точнее не понятно как) сделать, чтобы при разрыве соединения следующая сессия была через минуту. В остальном все ОК.</li>
