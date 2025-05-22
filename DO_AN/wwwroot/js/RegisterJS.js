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
        showError('phone', 'Vui lòng kiểm tra nhập lại SĐT');
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
    return flag;
}