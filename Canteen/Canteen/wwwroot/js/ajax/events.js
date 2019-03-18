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
    $(`#price_${$(e.target).attr('class')}`).text($(e.target).attr('value') + ' руб');
});

$("#content").delegate('.ti-shopping-cart', "click", function(e){
    if(e.target.id !="none"){
        if(sessionStorage["card"] != undefined)
            sessionStorage["card"] += `#${e.target.id}`;
        else
            sessionStorage["card"] = e.target.id;
        card.push(e.target.id);
    }
        
});
