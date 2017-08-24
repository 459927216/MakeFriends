var globaFn = function() {
    return {
        jump: function (url) {
            loading.begin();
            $("#content").load(url, function () {
                loading.end();
            });
        }
    }
}();

$(function () {
    $("body").on("click", ".header-nav ", function () {
        var $this = $(this);
        $("#header .header-nav").removeClass("aui-active");
        $this.addClass("aui-active");
        globaFn.jump($this.attr("url"));
    });

    $("body").on("click", ".bottom-nav", function () {
        var $this = $(this);
        $("#footer .bottom-nav").removeClass("aui-active");
        $(this).addClass("aui-active");
        globaFn.jump($this.attr("url"));
    });

    /*点击跳转事件*/
    $(document).on("click", ".link", function (e) {
        var $this = $(this);
        var url = $(this).attr("url-ajax");
        globaFn.jump(url);
    });
});
apiready = function () {
    api.parseTapmode();
}
var toast = new auiToast();
var loading = {
    begin: function () {
        toast.loading({ title: "加载中..." });
    },
    end: function () {
        toast.hide();
    }
};

var sharebox = new auiSharebox();
var openSharebox = function() {
    sharebox.init({
        frameBounces: true,//当前页面是否弹动，（主要针对安卓端）
        buttons: [{
            image: 'image/demo/person1.jpg',
            text: '1¥茉莉花',
            value: 'wx'//可选
        }, {
            image: 'image/demo/person1.jpg',
            text: '2¥么么哒',
            value: 'wx'//可选
        },
        {
            image: 'image/demo/person1.jpg',
            text: '9¥茉莉花',
            value: 'wx'//可选
        },
        {
            image: 'image/demo/person1.jpg',
            text: '13.14¥包包',
            value: 'wx'//可选
        },
        {
            image: 'image/demo/person1.jpg',
            text: '18.8¥包包',
            value: 'wx'//可选
        },
        {
            image: 'image/demo/person1.jpg',
            text: '52.0¥皇冠',
            value: 'wx'//可选
        }
        ],
        col: 3,
        cancelTitle: '关闭'//可选,当然也可以采用下面的方式使用图标
        // cancelTitle:'<i class="aui-iconfont aui-icon-close aui-font-size-16"></i>'//可选
    }, function (ret) {
        if (ret) {
            alert(ret.buttonIndex + "" + ret.buttonValue);
            //document.getElementById("button-index").textContent = ret.buttonIndex;
            //document.getElementById("button-value").textContent = ret.buttonValue;
        }
    })
}