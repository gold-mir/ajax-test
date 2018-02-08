var heckCount = 1;

var writeHeckDisplay = function(data){
    $("#heckdisplay").empty();
    data.forEach(function(item){
        $("#heckdisplay").append(`<li>${item}</li>`);
    })
}

$(document).ready(function(){
    $("#heck-number-update").submit(function(event){
        event.preventDefault();
        var newHecks = parseInt($("#heck-number-update input[name=heck-count]").val());
        if(!isNaN(newHecks)){
            if(newHecks > 0){
                heckCount = newHecks;
            }
        }
        console.log(`Heck Count: ${heckCount}`);
    });
    $("button[name=random-number-button]").click(function(event){
        $.ajax({
            url: "/rand",
            type: "GET",
            success: function(data){
                console.log(data);
            },
            error: function(){
                console.log("Didn't work");
            }
        });
    });
    $("button[name=heck-button]").click(function(event){
        $.ajax({
            url: "/heck",
            type: "POST",
            data: {numberOfHecks: heckCount},
            success: writeHeckDisplay,
            error: function(){
                console.log("Post didn't work");
            }
        });
    });
});
