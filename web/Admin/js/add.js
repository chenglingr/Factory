

$(document).ready(function () {

   
    //注册提交按钮单击事件
    $("#BtnOK").click(function () {

        var txtUserName = $("#txtLoginID").val(); //保存文本框对象，提高效率
     
        var txtPassWord = $("#txtLoginPWD").val();
        var txtRealName = $("#AdminName").val();
        var adminSex = true;
        var obj = document.getElementsByName("sex");
        if (obj[1].checked) { adminSex =false; }
        if ("" != txtUserName && "" != txtPassWord && "" != txtRealName)
        { //简单的验证放在客户端，减少服务器压力
            //利用post方式向服务器请求数据 

            $.ajax({
                type: "Post",
                url: "ashx/ADD.ashx",
                //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
                data: { "UserName": txtUserName, "PassWord": txtPassWord, "RealName": txtRealName, "adminSex": adminSex },
                dataType: "text",
                success: function (data) {
                   //返回类型为text时 要处理一下 
                    var json = eval('(' + data + ')');
                 
                    alert(json.info);
                },
                error: function (err) {
                    alert(err);
                }
            });
           

        }
        else
        {
           alert("输入非法！");
        }
    });

    //注册重置按钮单击事件
    $("#btnReset").click(function () {
         $("#txtLoginID").val(''); //保存文本框对象，提高效率
         $("#txtLoginPWD").val('');
         $("#AdminName").val('');
    });
});

