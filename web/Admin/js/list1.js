$(document).ready(function () {
   
        $.ajax({
            type: "Post",
            url: "ashx/list1.ashx",
            //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
            data: { "Action": "Show" },
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
                        data: data.Admin,//数据源
                        pagination: true, //分页
                        search: true, //显示搜索框
                        pageSize: 4,//每页的行数
                        showRefresh: true,//刷新
                        striped: true,//条纹

                    });
                }
               
            },
            error: function (err) {
                alert(err);
            }
        });

        //删除按钮
        $("#BtnDel").click(function () {
            var DelNumS = getCheck();
        //    alert(DelNumS);

            //判断是否为空。。前面是否有多余的 逗号.(如果是全选，前面会多个，)
            if (DelNumS.charAt(0) == ",") { DelNumS = DelNumS.substring(1);}

            if (DelNumS == "") { alert("请选择额要删除的数据"); }
            else
            {
                $.ajax({
                    type: "post",
                    url: "ashx/LIST.ashx",
                    data: { "Action": "Del", "DelNums": DelNumS },
                    dataType: "text",
                    success: function (data) {
                        var json = eval('(' + data + ')');
                        alert(json.info);
                        //刷新页面
                        window.location.reload();
                    }
                });

            }
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