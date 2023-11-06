/*
You are working on pricing system function that allows the calling code to 
pass in a function that modifies the price.
*/

const ten_percent_off = function (x) { return x * .9 };
const senior_citizen = x => 1;

calculatePrice("toy", 100, senior_citizen)
calculatePrice("toy", 100, double_the_price)
calculatePrice("toy", 100, ten_percent_off)
calculatePrice("toy", 100, x => x = x / 2)


function calculatePrice(itemname, price, f) {
    const origprice = price;
    const fname = f.name ? f.name : f.toString();
    price = f(price);
    console.log(`Base price for ${itemname} is ${origprice} changed to ${price}. Calculated with ${fname}`)
}

function double_the_price(x) {
    //return x = x * 2;
    return x + Math.floor(Math.random() * 100);
}

//console.log(Math.floor(Math.random() * 100))