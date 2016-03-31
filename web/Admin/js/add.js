

$(document).ready(function () {
    var txtUserName = $("#txtLoginID"); //保存文本框对象，提高效率
    var txtPassWord = $("#txtLoginPWD");
    var txtRealName = $("#AdminName");
    var adminSex = true;
    var obj = document.getElementsByName("sex");
    if (obj[1].checked) { adminSex =false; }
   
    //注册提交按钮单击事件
    $("#BtnOK").click(function () {
        if ("" != txtUserName.val() && "" != txtPassWord.val() && "" != txtRealName.val())
        { //简单的验证放在客户端，减少服务器压力
            //利用post方式向服务器请求数据 
    
            $.ajax({
                type: "Post",
                url: "ashx/ADD.ashx",
                //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
                data: "{'UserName':txtUserName,'PassWord':txtPassWord,'RealName':txtRealName,'adminSex':adminSex}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    //返回的数据用data.d获取内容   
                    alert(data);
                },
                error: function (err) {
                    alert(err);
                }
            });
           

        } else {
            alert("输入非法！");
        }
    });

    //注册重置按钮单击事件
    $("#btnReset").click(function () {
        txtLoginID.val("");
        txtLoginPWD.val("");
    });
});

