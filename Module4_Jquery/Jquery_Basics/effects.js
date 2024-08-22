
$(document).ready(function() {
    $("#animate-button").click(function() {
        $(".container").animate({
            width: "200px",
            height: "200px",
            opacity: 0.5
        }, 1000);
    });

    $("#apply-animation").click(function(){
        $("#normal-state")
        .queue(function (next){
            $(this).animate({width: "200px" , opacity: 0.7},2000);
            next();
        })
        .queue(function (next){
            $(this).animate({height: "200px" , opacity : 0.4},2000);
            next()
        })
    })
});
