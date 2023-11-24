/*
You are developing software for an underwater café that serves submarine sailors. 
This café is unique as it offers various delivery methods for food, either through the periscope, torpedo tube, or hatch.
The menu is limited to Sea Salad, Burger with Seaweed Fries, and Galaxy Shake.
Additionally, each food item can be ordered in either regular or concentrate form. 
Sailors can also provide special instructions for their orders. 
Orders can be placed in any quantity. 
Each order has a unique sequential number starting at 1000.

Your task is to write a script that outputs these orders to the console, ensuring each one is logged with its details and special instructions.
There is a specific format for how the orders should be output to the console, as follows:
1) Order quantity should be stated as "Qty = quantity".
2) The delivery method should be the first letter of the method enclosed in square brackets.
3) Food form, regular or concentrate, should be represented by the first letter of the form in parentheses.
4) The format of the whole order is:
    "Qty = [quantity]: [delivery method] - [menu item] (food form) - SI: [special instructions];"
    Example: "Qty = 7: [h] - Burger with Seaweed Fries (c) - SI: No onions, extra seaweed;"
5) Omit the order number from the order output.

Each order should also be kept in memory so that at the end of the day, you can output all the orders for the day.
The end-of-day output should list all elements of each order on one line, separated by dashes. 
The order number should be the first element of the end-of-day output.
*/

enum DeliveryMethod { periscope = 'p', torpedoTube = 't', hatch = 'h' }
enum FoodForm { regular = 'r', concentrate = 'c' }
enum MenuItem { seaSalad = 'Sea Salad', burgerWithSeaweedFries = 'Burger with Seaweed Fries', galaxyShake = 'Galaxy Shake' }

let ordernum = 1000;
let submarineOrders: [number, number, DeliveryMethod, MenuItem, FoodForm, string][] = [];

function logSubmarineOrder(quantity: number, dmethod: DeliveryMethod, mitem: MenuItem, fform: FoodForm, specialInstructions: string): void {
    ordernum++;
    submarineOrders.push([ordernum, quantity, dmethod, mitem, fform, specialInstructions]);
    let orderEntry = `Qty: ${quantity} - [${dmethod}] - ${mitem} (${fform}) - Special: ${specialInstructions};`;
    console.log(orderEntry);
}

function OutputSubmarineOrders() {
    console.log("---------Submarine SeaStar Café Order Log------------")
    submarineOrders.forEach(o => console.log(`${o[0]} - Qty: ${o[1]} - ${o[2]} - ${o[3]} - ${o[4]} - Special: ${o[5]}`));
}

// Example Usage
logSubmarineOrder(2, DeliveryMethod.periscope, MenuItem.seaSalad, FoodForm.regular, "Extra dressing on the side");
logSubmarineOrder(1, DeliveryMethod.hatch, MenuItem.burgerWithSeaweedFries, FoodForm.concentrate, "No onions, extra seaweed");
logSubmarineOrder(3, DeliveryMethod.torpedoTube, MenuItem.galaxyShake, FoodForm.regular, "With a sprinkle of stardust");
OutputSubmarineOrders();

export { };