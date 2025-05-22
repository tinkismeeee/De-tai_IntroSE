window.onload = function () {
    window.document.getElementById('quantity').value = 1;
    var sl = parseFloat(document.getElementById('quantity').value);
    var giatien = parseFloat(document.getElementById('price').innerHTML);
    window.document.getElementById('total').innerHTML = sl * giatien + '₫';
    window.document.getElementById('total1').innerHTML = sl * giatien + '₫';
};
function calculatorBill() {
    var giatien = parseFloat(document.getElementById('price').innerHTML);
    var sl = parseFloat(document.getElementById('quantity').value);
    if (sl < 0) {
        alert("The quantity cannot be less than zero");
        sl = 1;
        window.document.getElementById('quantity').value = sl;
    }
    if (sl === "") {
        alert("The quantity cannot be hollow");
        sl = 1;
        window.document.getElementById('quantity').value = sl;
    }
    window.document.getElementById('total').innerHTML = sl * giatien + '₫';
    window.document.getElementById('total1').innerHTML = sl * giatien + '₫';
}
//Increase and 
let Increase = document.getElementById('increase');
let Reduce = document.getElementById('reduce');
var x = 0;
Increase.addEventListener('click', () => {
    var giatien = parseFloat(document.getElementById('price').innerHTML);
    var sl = parseFloat(document.getElementById('quantity').value);
    sl++;
    window.document.getElementById('quantity').value = sl;
    window.document.getElementById('total').innerHTML = (x + sl) * giatien + '₫';
    window.document.getElementById('total1').innerHTML = (x + sl) * giatien + '₫';
})
Reduce.addEventListener('click', () => {
    var sl = parseFloat(document.getElementById('quantity').value);
    var giatien = parseFloat(document.getElementById('price').innerHTML);
    sl--;
    if (sl < 0) {
        alert("The quantity cannot be less than zero");
    }
    else {
        window.document.getElementById('quantity').value = sl;
        window.document.getElementById('total').innerHTML = (x + sl) * giatien + '₫';
        window.document.getElementById('total1').innerHTML = (x + sl) * giatien + '₫';
    }
})


