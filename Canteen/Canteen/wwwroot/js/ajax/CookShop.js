function getCookShopList()
{
    $.ajax(
        {
            type: 'GET',
            url: '/cookshop/CookShopList',
            dataType: "html",
            success: function (data, textStatus) {
                $('#cslist').html(data);
            }
        });
};

function getCookShopCards() {
    $.ajax(
        {
            type: 'GET',
            url: '/cookshop/CookShopCards',
            dataType: "html",
            success: function (data, textStatus) {
                $('#content').html(data);
            }
        });
};

function getCookShopInfo(id){
    $.ajax(
        {
            type: 'GET',
            url: `/cookshop/CookShopInfo/${id}`,
            dataType: "json",
            success: function (data, textStatus) {
                $('#cs_logo').html(`<h3 class="logo">${data.title}</h3>`);
                if(data.isOpen)
                    $('#cs_time').html(`<h2 style="color:green">Открыто</h2>`);
                else
                     $('#cs_time').html(`<h2 style="color:red">Закрыто</h2>`);
            }
        });
}