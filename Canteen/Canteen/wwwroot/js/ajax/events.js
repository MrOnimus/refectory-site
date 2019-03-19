$("#content").delegate(".cookShopItem", "click", function (e) {
    getCategoryList(e.target.id);
    getDishByCookShopCards(e.target.id);
});

$("#cslist").delegate(".ctgListItem", "click", function (e) {
    getCategoryList(e.target.id);
    getDishByCookShopCards(e.target.id);
});

$('#ctgList').delegate(".ctgListItem", "click", function (e) {
    getDishByCategoryCards(e.target.id);
});

$("#content").delegate('.tabs input', "click", function(e){
    $(`#t_${$(e.target).attr('class')} h2 a span`).attr("id", e.target.id);
    $(`#t_${$(e.target).attr('class')} h2 a span`).attr("data-price", $(e.target).attr('data-price'));
    $(`#t_${$(e.target).attr('class')} h2 a span`).attr("data-size", $(e.target).attr('data-size'));
    $(`#price_${$(e.target).attr('class')}`).text($(e.target).attr('data-price') + ' руб');
});

$("#content").delegate('.ti-shopping-cart', "click", function(e){
    if(e.target.id !="none"){
        addToCart(e);
    }
        
});

$('#show_cart').click(function(){
    getCart();
});

$('#clean_card').click(function(){
    cleanCart();
});

$('.shopping__cart').delegate(".close","click", function (e){
    removeItem($(e.target).attr('data-id'));
});


