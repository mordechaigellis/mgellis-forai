// resize.js

// Function to handle window resize
function handleResize() {
    const width = window.innerWidth;
    const height = window.innerHeight;
    let bpoint = "xs";

    switch (true) {
        case width >= 1400:
            bpoint = "xxl";
            break;
        case width >= 1200:
            bpoint = "xl";
            break;
        case width >= 992:
            bpoint = "lg";
            break;
        case width >= 768:
            bpoint = "md";
            break;
        case width >= 576:
            bpoint = "sm";
            break;
    }

    document.getElementById("msg").innerHTML = `${bpoint} Width = ${width} Height = ${height}.`;
}

// Add event listener for window resize
window.addEventListener("resize", handleResize);

// Add event listener for page load
document.addEventListener("DOMContentLoaded", handleResize);
