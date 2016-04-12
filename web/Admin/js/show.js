function getUrlParam(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //构造一个含有目标参数的正则表达式对象
    var r = window.location.search.substr(1).match(reg);  //匹配目标参数
    if (r != null) return unescape(r[2]); return null; //返回参数值
}
/*
js定义多行字符串
var htmlSTring = '<div style="font-color:red;">\
  This is a string.\
</div>';
*/
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
                //   tbody.append(data.LoginID + "<br/>" + data.AdminName);
                var sex = '女';
                if (data.sex == true) { sex = '男'; }
            

                var outStr= '<table cellSpacing="0" cellPadding="0" width="100%" border="0">\
	         	<tr>  <td height="45" width="30%" align="right"> 编号：</td> <td > ' + data.adminID + ' </td></tr> \
                <tr>  <td height="45" align="right"> 登录名：</td> <td> ' + data.LoginID + ' </td></tr> \
	          	<tr>  <td height="45" align="right"> 密码：</td> <td> ' + data.LoginPWD + ' </td></tr> \
                <tr>  <td height="45" align="right"> 真实姓名：</td> <td> ' + data.AdminName +  ' </td></tr> \
	            <tr>  <td height="45" align="right"> 性别：</td> <td> ' + sex +  ' </td></tr>\
            </table>';

                tbody.append(outStr);

              //  alert(data.LoginID + data.AdminName);
            },
            error: function (err) {
                alert(err);
            }
        });
    }
    else { alert('地址有误');}


});

