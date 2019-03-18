var card = new Array();
if (sessionStorage["card"] != undefined)
    card = sessionStorage["card"].split('#');
console.log(card);   
$(document).ready(function () {
    getCookShopList();
    getCookShopCards();
});