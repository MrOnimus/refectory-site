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