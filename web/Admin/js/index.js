$(document).ready(function () {
    
        $.ajax({
            type: "Post",
            url: "ashx/index.ashx",
            data: { "Action": "Show" },
            dataType: "json",
            success: function (data) {
               
                var tbody = $('#showlist');
               if (jQuery.isEmptyObject(data)) { //json数据为空
                 
                    alert("无数据");
               }
                else
                {
                    //用json返回数据行时
                    $.each(data.Admin, function (index, item) {//显示数据1
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

                   tbody = $('#top5');
                    $.each(data.top5, function (index, item) {//显示数据2
                        var str = '<li>' + item. stuNo+'  '+item.stuRealName + '</li>';
                        tbody.append(str);
                    });
                }
               
            },
            error: function (err) {
                alert(err);
            }
        });
  
});