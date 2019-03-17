function getCategoryList() {
    $.ajax(
        {
            type: 'GET',
            url: '/category/CategoryList',
            dataType: "html",
            success: function (data, textStatus) {
                $('#ctgList').html(data);
            }
        });
};