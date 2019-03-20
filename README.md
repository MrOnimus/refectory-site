refectory-site
<h2> Сайт заказа блюд в столовых </h2>

Что это?
Адаптивный сайт заказа блюд в столовых с возможностью выбора столовых, категорий блюд, отображением времени работы, возможностью работы со всех устройств, имеющих экран. На сайте можно выбрать блюдо, размер порции, добавить его в корзину и узнать итоговую сумму и калорийность набора. Администратор через свою страницу может свободно конфигурировать меню столовых. Во всех необходимых местах имеются пояснительные комментарии.

Установка и запуск

  Для успешного запуска приложения, вам необходимо установить на свой компьютер .Net Core SDK 2.2 (https://dotnet.microsoft.com/download).
  После этого, вы можете открыть проект в Visual Studio(если таковая имеется) и запустить. Либо же вам необходимо перейти в /refectory-site/Canteen, а далее ввести следующие команды в консоль:
  
  dotnet restore
  dotnet run --project Canteen
  
  После чего, проект будет доступен по адрессу http://localhost:5010/index.html, а панель администратора, необходимая для добавления контента на сатй, будет находится http://localhost:5010/admin

Вёрстка
Вёрстка расположена в файле index.html (проект cantine, папка wwwroot), а также в папке views, где находится вёрстка карточек столовой, блюд, меню, заполняемые данными из БД, а также вёрстка страницы администратора, откуда он может изменять меню.
Для качественного дизайна и лучшей адаптивности вёрстка выполнена с использованием фреймворка bootstrap (скачан в проект), а также медиа-запросов в CSS, позволяющих менять стили определённых элементов для разной ширины экрана. 
Основные стили расположены в style.css, специальные, например для навбара и футера, а также медиа-запросов, в папке CSS (проект cantine, папка wwwroot). 
Для работы кнопок открытия/закрытия корзины и меню на малых экранах использован JS в скипте в концe index.html.
Вёрстка подразумевает обязательный выбор граммовок администратором (что обусловлено бизнес процессами), а также выбор порции пользователем перед отображением цены. После нажатии кнопки "купить" она остаётся выделенной для удобства навигации и ориентации пользователя.

Анимация

Бэкенд

Сведения об авторах и контакты


