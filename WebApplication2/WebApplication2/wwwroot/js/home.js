function CreateArticle() {
    var myUrl = "/Article/CreateArticle";
    $.ajax({
        url: myUrl,
        type: "GET",
        success: function (response) {
            $("#CreateArticleFormPartial").html(response);
        }
    });
}
