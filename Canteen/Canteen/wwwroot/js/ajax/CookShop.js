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