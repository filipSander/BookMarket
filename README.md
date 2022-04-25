# BookMarket

## Необходимые действия для запуска. 
+ В проекте используется библиотека MySqlData для работы с диалектом MySql. (экземпляр которой я оставил в проекте).
+ СУБД MySql. (Бэкап бд в одноименном файле `bookmarket.sql`).
+ Настроить подключение к бд в файле `DataBase.cs` 
  + `MySqlConnection connection = new MySqlConnection("server=??;port=??;username=??;password=??;database=??;");`

## Описание бд

![Логическая модель](https://user-images.githubusercontent.com/94076463/165090074-3620b0eb-284d-4383-90c6-a27ddbb392a3.jpg "Логическая модель, построенная в программе ERwin data modeler")
![Физическая модель](https://user-images.githubusercontent.com/94076463/165090077-254aed8b-eb91-4284-9c23-bb8415f2c29c.jpg "Физическая модель, построенная в программе ERwin data modeler")
