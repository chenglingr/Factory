function getUrlParam(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
    var r = window.location.search.substr(1).match(reg);  //匹配目标参数
    if (r != null) return unescape(r[2]); return null; //返回参数值
}

$(document).ready(function () {
    var Userid = getUrlParam('UserID');
    if (Userid != null) {
        $.ajax({
            type: "Post",
            url: "ashx/SHOW.ashx",
            //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
            data: { "UserID": Userid },
            dataType: "json",
            success: function (data) {
                var tbody = $('#showinfo');
                //用json返回一个对象数据
                tbody.append(data.LoginID +"<br/>" +data.AdminName);
              //  alert(data.LoginID + data.AdminName);
            },
            error: function (err) {
                alert(err);
            }
        });
    }
    else { alert('地址有误');}


});

