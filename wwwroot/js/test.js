var heckCount = 1;

var ಠ_ಠ = function(){
    alert ("Unknown error");
}

var test = function(){
    console.log("test");
}

var writeHeckDisplay = function(data){
    $("#heckdisplay").empty();
    data.forEach(function(item){
        var times = item.split("Heck the number ")[1];
        $("#heckdisplay").append(`<li>${"🤔".repeat(times)}</li>`);
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
            error: ಠ_ಠ
        });
    });
    $("button[name=heck-button]").click(function(event){
        $.ajax({
            url: "/heck",
            type: "POST",
            data: {numberOfHecks: heckCount,
                data: {name: "fred", occupation: "some guy", dogs: 3, action: test}},
            success: function(data){
                console.log(data);
            },
            error: ಠ_ಠ
        });
    });
});
