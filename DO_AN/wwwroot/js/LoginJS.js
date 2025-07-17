function CheckIsvalid() {
    var flag = true;
    var tendangnhap = document.getElementById("tendangnhap").value;
    var nhapmatkhau = document.getElementById("nhapmatkhau").value;
    if (tendangnhap == "" || nhapmatkhau == "") {
        flag = false;
        document.getElementById("error").style.visibility = "visible";
        // console.log(flag + tendangnhap + " " + nhapmatkhau + "\n");
    }
    return flag;
}