##  Без Tarakanoff
[![Без тараканофф](https://i.ibb.co/nk5F5b1/logoMint.jpg "Без тараканофф")](https://i.ibb.co/nk5F5b1/logoMint.jpg "Без тараканофф")

## Что это?
###### Адаптивный сайт заказа блюд в столовых с возможностью выбора столовых, категорий блюд, отображением времени работы, возможностью работы со всех устройств, имеющих экран. На сайте можно выбрать блюдо, размер порции, добавить его в корзину и узнать итоговую сумму и калорийность набора. Администратор через свою страницу может свободно конфигурировать меню столовых. Во всех необходимых местах имеются пояснительные комментарии.

## Установка и запуск
###### Для успешного запуска приложения, вам необходимо установить на свой компьютер [.Net Core SDK 2.2](https://dotnet.microsoft.com/download ".Net Core SDK 2.2") 

###### После этого, вы можете открыть проект в Visual Studio(если таковая имеется) и запустить. Либо же вам необходимо перейти в "/refectory-site/Canteen", а далее ввести следующие команды в консоль:

```bash
dotnet restore
dotnet run --project Canteen
```
###### Основоной контент сайта станет доступен по адрессу: 
>  http://localhost:5010/index.html

###### Панель администратора можно запустить по ссылке:
>  http://localhost:5010/admin

## О разработке

- ###### Backend был написан с использованием программной среды .Net Core 2.1(2.2) на языке программирования C#.
- ###### В качестве СУБД используется SqlLite
- ###### Для работы с базой данных используется Entity Framework Core 2.1(2.2)
- ###### Для разработки Frontend использовался HTML, CSS, JavaScript
- ###### Были задействованы Bootstrap v4.3.1, JQuery v3.3.1, ScrollRevealJS
- ###### Шрифты брались с помощью Google Fonts
- ###### Для изменения содержимого страницы используется технология AJAX

## Структура проекта
#### Приложение поделено на 3 модуля:
<b>1. Модуль Canteen.Data</b>
###### - Определяет основные сущности(классы), используемые в проекте (находятся в папке "Entities")
###### - Задает интерфейсы репозиториев, необходимые для работы с сущностями (в основном заимодействие с БД, находятся в папке "Repositories")
<b>2. Модуль Canteen.Core</b>
###### - Реализация репозиториев, на основе интерфейсов, определенных в предыдущем модуле (находятся в папке "Repositories")
###### - Определены сервисы (классы, содержащие основную логику, не относящуюся к репозиториям, находятся в папке "Services")
###### - Класс контекста, необходимый для Entity Framework Core (находится в папке "EF")
<b>3. Модуль Canteen</b>
###### - Содержит стандартную структуру ASP.NET Core приложения (это файлы Startup.cs, Program.cs, appsettings.json, папки Controllers, Views, wwwroot)
###### - В appsettings.json определены некоторые настройки приложения. Так же в этом файле находится строка подключения к БД
###### - cookshob.db - файл БД SqlLite
###### - В папке Controllers определены контроллеры(понятие паттерна [MVC](https://ru.wikipedia.org/wiki/Model-View-Controller "MVC")). Контроллер Admin используется для панели администратора, остальные нужны для функционирования самого сайта столовой
###### - В каталоге Views определена мастер-страница(шаблон) для панели администратора, а так же [частичные представления](https://metanit.com/sharp/aspnet5/7.5.php "частичные представления") для сайта столовой
###### - В Configurations вынесены классы, один из которых отвечает за подключение БД к проекту, а второй за добавление репозиторие и сервисов в IServiceCollection, что необходимо для использования их в механизме [внедрения зависимостей](https://ru.wikipedia.org/wiki/%D0%92%D0%BD%D0%B5%D0%B4%D1%80%D0%B5%D0%BD%D0%B8%D0%B5_%D0%B7%D0%B0%D0%B2%D0%B8%D1%81%D0%B8%D0%BC%D0%BE%D1%81%D1%82%D0%B8 "внедрения зависимостей")
###### - wwwroot содержит все файлы, необходимые для Frontend (страницу сайта - index.html, файлы стилей(.css), скриптов(.js), а так же некоторые изображения и файлы шрифтов )

## Сценарий работы с сайтом столовой
<b>1. Шапка сайта</b>
###### - Выбор столовой с помощью выпадающего списка "Выбрать столовую" в центральной части
###### - Перезагрузить страницу по щелчку на лого в левой части
###### - На "Страница столовой" лого отображает название столовой
###### - Открыть корзину покупок по щелчку на значок в правой части (см. п.4)
<b>2. Подвал сайта</b>
###### - Тут находится типичная для этой части сайта информация, которая не является реальной
<b>3. Карточка блюда</b>
###### - Отображает изображение блюда, название, а так же доступные для выбора размеры порции
###### - При наведение курсора мыши, показывает информацию о калориях, а так же соотношение белков/жиров/углеводов в блюде
###### - При щелчке по размеру порции, соответвующая загорается красным цветом, после чего ниже появляется цена
###### - При щелчке по корзине, блюдо выбранной размерности помещается в корзину
<b>4. Корзина</b>
###### - Отображает текущий список выбранных вами блюд, сохраняется в случае перезагрузки страницы
###### - В каждом пункте корзины находится следующая информация о блюде:
    Изображение
	Название
	Количество
	Калории
	Белки
	Жиры
	Углеводы
	Цена
###### - При щелчке на крестик в правом верхнем углу пункта корзины, блюдо убирается 
###### - При щелчке на крестик в правом верхнем углу корзины, мы снова переходим к контенту сайта 
###### - Внизу представлена информация об итоговой стоимости и суммарном количестве калорий 
###### - При щелчке на кнопку "Купить" в нижней части корзины, произойдет перезагрузка страницы (кнопка носит декаративный характер)
###### - При щелчке на кнопку "Очистить" в нижней части корзины, убираются все товары, находящиеся в корзине
<b>5. Страница выбора столовой</b>
######  На этой странице вам представлены следующие возможности:
###### - Действия из п.1, п.2 и п.4
###### - Перейти на "Страница столовой" по щелчку на соответствующее название на карточке столовой
<b>6. Страница столовой</b>
######  На этой странице вам представлены следующие возможности:
###### - Действия из п.1, п.2, п.3 и п.4
###### - сохраняется возмодность перезагрузить страницу по щелчку на лого в верхнем левом углу сайта
###### - Перезагрузить страницу по щелчку на лого в верхнем левом углу сайта
###### - Открыть корзину покупок по щелчку на значок в правой верхней части сайта(см. п. N. "Работа с корзиной")
###### - Изначально отображает все блюда, относящиеся к данной столовой
###### - При щелчке по категории, находящейся слева от главного контента под надписью "Меню", отображаются блюда из соответствующей категории 




