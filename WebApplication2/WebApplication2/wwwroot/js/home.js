function CreateArticle() {
    var myUrl = "/Article/CreateArticle";
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            $("#SchoolUpdateFormPartial").html(response);
        }
    });
}
