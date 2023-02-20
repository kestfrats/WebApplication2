$(document).ready(function () {
    $.ajax({
        url: "/Blog/Article/Timeline",
        type: "GET",
        success: function (response) {
            $("#timeline").html(response);
        }
    });
})
$(document).ready(function () {
    $.ajax({
        url: "/Blog/Hashtag/GetHashtag",
        type: "GET",
        success: function (response) {
            $("#hashtags").html(response);
        }
    });
})

//function formSubmit() {
//    $("#fail").html("");
//    var formdata = new FormData();
//    formdata.append('headline', $("#Headline").val());
//    formdata.append('content', $("#Content").val());
//    formdata.append('readableTime', $("#ReadableTime").val());

//    //Bir nesne ile de yollayabilirsiniz. Formdata ile dosya da gönderebilirsiniz.

//    var myUrl = "/Blog/Article/Create";

//    if ($('#createArticleForm').valid()) {
//        $.ajax({
//            url: myUrl,
//            type: "POST",
//            data: formdata,
//            processData: false,
//            contentType: false,
//            success: function (response) {
//                if (response == "ok") {
//                   console.log(response)
//                }
//                else {
//                    $("#fail").append('<div class="alert alert-danger" role="alert">Error! Article addition failed.</div>');
//                }
//            }
//        });
//    }
//}
