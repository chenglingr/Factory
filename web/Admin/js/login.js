$(document).ready(function () {
    //注册提交按钮单击事件
    $("#BtnOK").click(function () {

        var txtUserName = $("#txtLoginID").val(); //获取文本框的值
        var txtPassWord = $("#txtLoginPWD").val();
     
        if ("" != txtUserName && "" != txtPassWord ) {   //简单的验证放在客户端，减少服务器压力
            //利用post方式向服务器请求数据 
            $.ajax({
                type: "Post",
                url: "ashx/LOGIN.ashx",
                //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
                data: { "UserName": txtUserName, "PassWord": txtPassWord },
                dataType: "text",
                success: function (data) {
                    //返回类型为text时 要处理一下 
                    var json = eval('(' + data + ')');
                 //   $("#result").val(json); 
                   alert(json.info+" "+json.ID);
                },
                error: function (err) {
                    alert(err);
                }
            });
        }
        else {
            alert("输入非法！");
        }
    });
       
});
