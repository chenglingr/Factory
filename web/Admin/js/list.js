$(document).ready(function () {
   
        $.ajax({
            type: "Post",
            url: "ashx/LIST.ashx",
            //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
          
            dataType: "json",
            success: function (data) {

                var tbody = $('#showlist');
                if (jQuery.isEmptyObject(data)) { //json数据为空
                    alert("请先登录");
                    window.location.href = "login.html";
                }
                else
                {
                    //用json返回数据行时
                    $.each(data.Admin, function (index, item) {
                        var str = '<tr>\
                            <td style="text-align: center; ">\
                                 <a href="show.html?UserID='
                                     + item.adminID + '">'+ item.LoginID 
                                 + '</a>\
                            </td>\
                           <td style="text-align: center; ">' + item.AdminName
                           + '</td>\
                        <\tr>';
                        tbody.append(str);
                    });
                }
               
            },
            error: function (err) {
                alert(err);
            }
        });
  
});