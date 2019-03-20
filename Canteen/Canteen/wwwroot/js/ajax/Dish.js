function getDishByCookShopCards(id) {
    $('#content').html(getLoader());
    $.ajax(
        {
            type: 'GET',
            url: `/dish/DishesByCookShopList/${id}`,
            dataType: "html",
            success: function (data, textStatus) {
                $('#content').html(data);
            }
        });
};

function getDishByCategoryCards(id) {
    $('#content').html(getLoader());
    $.ajax(
        {
            type: 'GET',
            url: `/dish/DishesByCategoryList/${id}`,
            dataType: "html",
            success: function (data, textStatus) {
                $('#content').html(data);
            }
        });
};