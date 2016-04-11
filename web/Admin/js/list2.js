$(document).ready(function () {
    
        $.ajax({
            type: "Post",
            url: "ashx/LIST2.ashx",
            data: { "Action": "Show" },
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

            /*        tbody = $('#top5');
                    $.each(data.Table_AX, function (index, item) {
                        var str = '<li>' + item.column0 + '<\li>';
                        tbody.append(str);
                    });*/
                }
               
            },
            error: function (err) {
                alert(err);
            }
        });
  
});