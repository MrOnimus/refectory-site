function getCartData(){
  return JSON.parse(sessionStorage.getItem('cart'));
}

function cleanCart(){
    sessionStorage.clear();
    getCart();
}

function setCartData(i){
  sessionStorage.setItem('cart', JSON.stringify(i));
  return false;
}

function addToCart(e)
{
    let cartData = getCartData() || {};
    let img = $(e.target).attr('data-img');
    let clr = $(e.target).attr('data-clr');
    let pr = $(e.target).attr('data-pr');
    let crb = $(e.target).attr('data-crb');
    let fat = $(e.target).attr('data-fat');
    let title = $(e.target).attr('data-title');
    let price = $(e.target).attr('data-price');
    let size = $(e.target).attr('data-size');
    let id = e.target.id;
    if(cartData.hasOwnProperty(id))
        cartData[id][0] += 1;
    else
        cartData[id] = [1, title, img, price, size, clr, pr, crb, fat];
    setCartData(cartData);
}

function getCart(){
    let cart = "";
    let price = 0;
    let clr = 0;
    let cartData = getCartData() || {};
    for(var items in cartData)
    {
        cart += getCartString(cartData[items], items);
        price += Number(cartData[items][0]) * Number(cartData[items][3])
        clr += Number(cartData[items][5] * cartData[items][4]/100 * cartData[items][0]);
    }
    $('#cart_content').html(cart);
    $('#total__price').html(price + ' руб');
    $('#shp__calories').html(clr + ' ккал');
}

function removeItem(id){
    let cartData = getCartData() || {};
    delete cartData[id];
    setCartData(cartData);
    getCart();  
}