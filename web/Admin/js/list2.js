var PageCount = 0;   //总条目数
var pageIndex = 0;     //页面索引初始值   
var pageSize = 5;     //每页显示条数初始化，修改显示条数，修改这里即可   

$(document).ready(function () {

     //  getNum();//获取记录总条数
                   $('#table').bootstrapTable({
                    url:"ashx/list2.ashx",//数据源
                    sidePagination: 'server',//设置为服务器端分页
                    pagination: true, //是否分页
                    search: true, //显示搜索框
                    pageSize: 5,//每页的行数 
                    pageList: [5, 10, 20],
                    pageNumber: 1,//显示的页数
                    showRefresh: true,//刷新
                    striped: true,//条纹
                    sortName: 'adminID',
                    sortOrder: 'desc',

                });
        
  

    //删除按钮
    $("#BtnDel").click(function () {
        var DelNumS = getCheck();//获取选中行的人的编号
        //    alert(DelNumS);

        //判断是否为空。。前面是否有多余的 逗号.(如果是全选，前面会多个，)
        if (DelNumS.charAt(0) == ",") { DelNumS = DelNumS.substring(1); }

        if (DelNumS == "") { alert("请选择额要删除的数据"); }
        else
        {
            $.ajax({
                type: "post",
                url: "ashx/LIST2.ashx",
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

function getNum() {
    $.ajax({
        type: "Post",
        async: false, //这里要这样 才能给全局变量赋值
        url: "ashx/getNum.ashx",
        //方法传参的写法一定要对，str为形参的名字,str2为第二个形参的名字   
        dataType: "text",
        success: function (data) {
            //返回类型为text时 要处理一下 
            var json = eval('(' + data + ')');
            PageCount = json.info;

        }
    });
}

function SEXFormatter(value, row, index) { //处理性别的显示
    if (value == 'True') {
        value = '男';
    }
    else {
        value = '女';
    }
    return value;
}
function editFormatter(value, row, index) { //处理操作

    var str = '<a href="modify.aspx?id=' + value + '">编辑</a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="show.html?UserID=' + value + '">详情</a>'
    value = str;
    return value;
}

function getCheck() { //获取表格里选中的行 的编号
    var data = [];//数组
    $("#table").find(":checkbox:checked").each(function () {
        var val = $(this).parent().next().text();//当前元素的上一级---里的下一个元素--的内容
        data.push(val);
    });
    return data.join(",");//用，连接
}