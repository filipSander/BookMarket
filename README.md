# BookMarket

## Необходимые действия для запуска. 
+ В проекте используется библиотека MySqlData для работы с диалектом MySql. (экземпляр которой я оставил в проекте).
+ СУБД MySql. (Бэкап бд в одноименном файле `bookmarket.sql`).
+ Настроить подключение к бд в файле `DataBase.cs` 
  + `MySqlConnection connection = new MySqlConnection("server=??;port=??;username=??;password=??;database=??;");`

## Описание бд

![Логическая модель](https://user-images.githubusercontent.com/94076463/165080479-69fae666-ff0c-4521-bc46-4497193a7448.jpg "Логическая модель, построенная в программе ERwin data modeler")
![Физическая модель](https://user-images.githubusercontent.com/94076463/165080482-75da6ecc-beea-4915-bebb-598a566bcbf4.jpg "Физическая модель, построенная в программе ERwin data modeler")
