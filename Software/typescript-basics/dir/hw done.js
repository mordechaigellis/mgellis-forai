"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var DeliveryMethod;
(function (DeliveryMethod) {
    DeliveryMethod["periscope"] = "p";
    DeliveryMethod["torpedoTube"] = "t";
    DeliveryMethod["hatch"] = "h";
})(DeliveryMethod || (DeliveryMethod = {}));
var FoodForm;
(function (FoodForm) {
    FoodForm["regular"] = "r";
    FoodForm["concentrate"] = "c";
})(FoodForm || (FoodForm = {}));
var MenuItem;
(function (MenuItem) {
    MenuItem["seaSalad"] = "Sea Salad";
    MenuItem["burgerWithSeaweedFries"] = "Burger with Seaweed Fries";
    MenuItem["galaxyShake"] = "Galaxy Shake";
})(MenuItem || (MenuItem = {}));
let ordernum = 1000;
let submarineOrders = [];
function logSubmarineOrder(quantity, dmethod, mitem, fform, specialInstructions) {
    ordernum++;
    submarineOrders.push([ordernum, quantity, dmethod, mitem, fform, specialInstructions]);
    let orderEntry = `Qty: ${quantity} - [${dmethod}] - ${mitem} (${fform}) - Special: ${specialInstructions};`;
    console.log(orderEntry);
}
function OutputSubmarineOrders() {
    console.log("---------Submarine SeaStar Café Order Log------------");
    submarineOrders.forEach(o => console.log(`${o[0]} - Qty: ${o[1]} - ${o[2]} - ${o[3]} - ${o[4]} - Special: ${o[5]}`));
}
logSubmarineOrder(2, DeliveryMethod.periscope, MenuItem.seaSalad, FoodForm.regular, "Extra dressing on the side");
logSubmarineOrder(1, DeliveryMethod.hatch, MenuItem.burgerWithSeaweedFries, FoodForm.concentrate, "No onions, extra seaweed");
logSubmarineOrder(3, DeliveryMethod.torpedoTube, MenuItem.galaxyShake, FoodForm.regular, "With a sprinkle of stardust");
OutputSubmarineOrders();
//# sourceMappingURL=hw%20done.js.map