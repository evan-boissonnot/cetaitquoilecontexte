// Write your Javascript code.
(function ($) {
    "use strict"; 

    var shortHtmlTemplate = $("#template-short-context").html();
    var longHtmlTemplate = $("#template-long-context").html();
    var $shortContextList = $("#short-list");
    var $longContextList = $("#long-list");

    $("#btnAddContext").click(function () {
        $.ajax({
            url: '/Context/Add',
            dataType: "json",
            data: { value: $("#txtContent").val() }
        }).success(function (data) {
            $("#txtContent").val('');

            if (data.state == "OK") {
                replaceHtmlContent(data, shortHtmlTemplate, $shortContextList);
                replaceHtmlContent(data, longHtmlTemplate, $longContextList);
            }

        });
    });

    function replaceHtmlContent(data, htmlContent, $list) {
        var newShortContext = htmlContent;

        newShortContext = newShortContext.replace(/\{0\}/gi, data.item.id);
        newShortContext = newShortContext.replace(/\{1\}/gi, data.item.message);

        $list.append(newShortContext);
    };
})(jQuery); 
