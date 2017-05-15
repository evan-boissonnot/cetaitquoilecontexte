// Write your Javascript code.
(function ($) {
    "use strict"; 

    $("#btnAddContext").click(function () {
        $.ajax({
            url: '/Context/Add',
            dataType: "json",
            data: { value: $("#txtContent").val() }
        }).success(function () {
            $("#txtContent").empty();


        });
    });
})(jQuery); 
