$(document).ready(function () {
   
        $.ajax({
            type: "Post",
            url: "ashx/LIST.ashx",
            //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
          
            dataType: "json",
            success: function (data) {
              //  var tbody = $('#showlist');
                //用json返回数据行时
                if (jQuery.isEmptyObject(data)) {
                    alert("请先登录");
                    window.location.href = "login.html";
                }
                else {
                    $('#table').bootstrapTable({
                        data: data.Admin,
                        pagination: true, //分页
                        search: true, //显示搜索框
                        pageSize: 4,
                        showRefresh: true,
                        striped: true,

                    });
                }
               
            },
            error: function (err) {
                alert(err);
            }
        });

        $("#BtnDel").click(function () {
          alert(  getCheck());

        });
});

function SEXFormatter(value, row, index) {
    if (value == 'True') {
        value = '男';
    }
    else{
        value = '女';
    }
    return value;
}
function editFormatter(value, row, index) {
   
    var str = '<a href="modify.aspx?id=' + value + '">编辑</a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="show.html?UserID=' + value + '">详情</a>'
    value = str;
    return value;
}

function getCheck() {
    var data = [];
    $("#table").find(":checkbox:checked").each(function () {
        var val = $(this).parent().next().text();
        data.push(val);
    });
    return data.join(",");
}