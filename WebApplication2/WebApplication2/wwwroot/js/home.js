function CreateArticle() {
    var myUrl = "/Article/Index";
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            $("#SchoolUpdateFormPartial").html(response);
        }
    });
}
