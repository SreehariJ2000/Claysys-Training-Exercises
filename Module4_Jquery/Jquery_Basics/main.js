$(document).ready(function(){
    $("#button").click(function(){
        $("#test").html("<b> Have a nice day </b>"); 
    });


    $(".paragraph").on({
        mouseenter: function(){
            $(this).css("background-color", "yellow");
        },
        click: function(){
            $(this).text("Text changed: move the mouse over me");
        }
    });
});
