$(function () {
     $("body").on("click", ".view", function () {
            var url = $(this).data("target");
            $.post(url, function (data) { })
                .done(function (data) {
                    $("#modelView .modal-body").html(data);
                    $("#modelView").modal("show");
                })
                .fail(function () {
                    $("#modelView .modal-body").text("Error!!");
                    $("#modelView").modal("show");
                })
     });
 })