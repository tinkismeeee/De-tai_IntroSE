window.onload = function () {
    window.document.getElementById('quantity').value = 1;
    updateTotal();
};

// Increase and Decrease event listeners
let Increase = document.getElementById('increase');
let Reduce = document.getElementById('reduce');

Increase.addEventListener('click', () => {
    var sl = parseFloat(document.getElementById('quantity').value);
    sl++;
    window.document.getElementById('quantity').value = sl;
    updateTotal();
});

Reduce.addEventListener('click', () => {
    var sl = parseFloat(document.getElementById('quantity').value);
    if (sl > 1) {
        sl--;
        window.document.getElementById('quantity').value = sl;
        updateTotal();
    } else {
        alert("The quantity cannot be less than zero");
    }
});


function updateTotal() {
    var sl = parseFloat(document.getElementById('quantity').value);
    var giatien = 18890000;
    if (isNaN(sl) || sl <= 0) {
        sl = 1;
        window.document.getElementById('quantity').value = sl;
    }
    var temp = sl * giatien + 16590000;
    window.document.getElementById('total').innerHTML = temp.toLocaleString() + '₫';
    window.document.getElementById('total1').innerHTML = temp.toLocaleString() + '₫';
}

function calculatorBill() {
    var sl = parseFloat(document.getElementById('quantity').value);
    var giatien = 18890000;
    if (isNaN(sl) || sl <= 0) {
        alert("The quantity cannot be less than zero");
        sl = 1;
        window.document.getElementById('quantity').value = sl;
    }
    if (sl === "") {
        alert("The quantity cannot be hollow");
        sl = 1;
        window.document.getElementById('quantity').value = sl;
    }
    var temp = sl * giatien + 16590000;
    window.document.getElementById('total').innerHTML = temp.toLocaleString() + '₫';
    window.document.getElementById('total1').innerHTML = temp.toLocaleString() + '₫';
}
