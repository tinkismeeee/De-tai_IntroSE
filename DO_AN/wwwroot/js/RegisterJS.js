function getValue(id) {
    return document.getElementById(id).value.trim();
}
// Hiển thị lỗi
function showError(key, mess) {
    document.getElementById(key + '_error').innerHTML = mess;
}
// kiểm tra lỗi
function validate() {
    var flag = true;
    // 1 username
    var name = getValue('username');
    if (name == '' || name.length < 5) {
        flag = false;
        showError('username', 'Vui lòng kiểm tra lại Username');
    }
    //2.kt sdt
    var numphone = getValue('phone');
    if (numphone.length < 10) {
        flag = false;
        showError('phone', 'Vui lòng kiểm tra lại SĐT');
    }
    // 3. password
    var Password = getValue('password');
    var Repassword = getValue('repassword');
    if (Password == '' || Password.length < 8) {
        flag = false;
        showError('password', 'Vui lòng kiểm tra lại Password');
    }
    // 4. repassword
    var Repassword = getValue('repassword');
    if (Password != Repassword) {
        flag = false;
        showError('repassword', 'Vui lòng kiểm tra nhập lại Password');
    }
    console.log(flag);
    if (flag) {
        var magioithieu1 = document.getElementById("magioithieu1");
        var name = document.getElementById("name");
        var email = document.getElementById("email");
        var phone = document.getElementById("phone");
        var username = document.getElementById("username");
        var password = document.getElementById("password");
        var repassword = document.getElementById("repassword");
        var male_checkbox = document.getElementById("male_checkbox");
        var female_checkbox = document.getElementById("female_checkbox");
        var day = document.getElementById("day");
        var month = document.getElementById("month");
        var year = document.getElementById("year");
        console.log(magioithieu1.value + " " + name.value + " " + email.value + " " + phone.value + " " + username.value + " " + password.value + " " + repassword.value + " " + male_checkbox.value + " " + female_checkbox.value + " " + day.value + " " + month.value + " " + year.value + "\n");
        magioithieu1.value = name.value = email.value = phone.value = username.value = password.value = repassword.value = "";
        day.value = month.value = year.value = 0;
        male_checkbox.checked = female_checkbox.checked = false;
        
        
        document.getElementById("noti").innerHTML = "Đang chuyển hướng trong 3 giây";
        setTimeout(function () {
            document.getElementById("noti").innerHTML = "Đang chuyển hướng trong 2 giây";
        }, 1000);
        setTimeout(function () {
            document.getElementById("noti").innerHTML = "Đang chuyển hướng trong 1 giây";
        }, 2000);
        setTimeout(function () {
            // window.location.href = "https://localhost:7077/Home/Login";
            document.getElementById("noti").innerHTML = "";
        }, 3000);
        
    }
    return flag;
}
